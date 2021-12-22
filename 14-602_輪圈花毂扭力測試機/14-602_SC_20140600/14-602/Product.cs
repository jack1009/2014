using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;

namespace _14_602
{
    class Product
    {
        public int id { get; set; }
        public string BarcodeNo { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string MaxValue { get; set; }

        private string filestring= @"D:\TEST\" + DateTime.Now.Date.ToLongDateString()+@".xlsx";
        private string worksheetname="產品資料";

        //把資料寫入EXCEL檔案
        public void WriteToExcelFile(string barcode,string date,string time,string maxvalue)
        {
            FileInfo f = new FileInfo(filestring);
            if (f.Exists)       //檔案是否存在
            {
                try
                {
                    using (ProductDataDataContext pdc=new ProductDataDataContext())     //把資料庫的寫入檔案
                    {
                        if (pdc.ProductData!=null)
                        {
                            foreach (var item in pdc.ProductData)
                            {
                                ProductData p = item;
                                using (ExcelPackage ep = new ExcelPackage(new FileInfo(filestring)))
                                {
                                    ExcelWorksheet ews = ep.Workbook.Worksheets[worksheetname];
                                    int endrownumber = ews.Dimension.End.Row;
                                    ews.Cells[endrownumber + 1, 1].Value = endrownumber;
                                    ews.Cells[endrownumber + 1, 2].Value = p.BarcodeNo;
                                    ews.Cells[endrownumber + 1, 3].Value = p.Date;
                                    ews.Cells[endrownumber + 1, 4].Value = p.Time;
                                    ews.Cells[endrownumber + 1, 5].Value = p.MaxValue;
                                    ep.Save();
                                }
                            }
                        }
                        pdc.DeletTable();       //資料庫的資料寫入檔案後用預存程序刪掉TABLE
                    }
                    using (ExcelPackage ep = new ExcelPackage(new FileInfo(filestring)))    //寫入本次資料
                    {
                        ExcelWorksheet ews = ep.Workbook.Worksheets[worksheetname];
                        int endrownumber = ews.Dimension.End.Row;
                        ews.Cells[endrownumber + 1, 1].Value = endrownumber;
                        ews.Cells[endrownumber + 1, 2].Value = BarcodeNo;
                        ews.Cells[endrownumber + 1, 3].Value = Date;
                        ews.Cells[endrownumber + 1, 4].Value = Time;
                        ews.Cells[endrownumber + 1, 5].Value = MaxValue;
                        ep.Save();
                    }
                }
                catch (Exception)       //無法寫入檔案的資料寫入資料庫
                {
                    using (ProductDataDataContext pdc=new ProductDataDataContext())
                    {
                        ProductData pd = new ProductData();
                        pd.BarcodeNo = BarcodeNo;
                        pd.Date = Date;
                        pd.Time = Time;
                        pd.MaxValue = MaxValue;
                        pdc.ProductData.InsertOnSubmit(pd);
                        pdc.SubmitChanges();
                    }
                }
               
            }
            else        //檔案不存在,先建立當天的檔案,再存本次資料
            {
                using (ExcelPackage ep = new ExcelPackage(new FileInfo(filestring)))
                {
                    ExcelWorksheet ews = ep.Workbook.Worksheets.Add(worksheetname);
                    ews.Cells[1, 1].Value = "ID";
                    ews.Cells[1, 2].Value = "條碼編號";
                    ews.Cells[1, 3].Value = "日期";
                    ews.Cells[1, 4].Value = "時間";
                    ews.Cells[1, 5].Value = "測試最大值";
                    int endrownumber = ews.Dimension.End.Row;
                    ews.Cells[endrownumber + 1, 1].Value = endrownumber;
                    ews.Cells[endrownumber + 1, 2].Value = BarcodeNo;
                    ews.Cells[endrownumber + 1, 3].Value = Date;
                    ews.Cells[endrownumber + 1, 4].Value = Time;
                    ews.Cells[endrownumber + 1, 5].Value = MaxValue;
                    ep.Save();
                }
            }
        }
    }
}
