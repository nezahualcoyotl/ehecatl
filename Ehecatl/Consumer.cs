using Ehecatl.DymosWebService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ehecatl
{
    class Consumer
    {
        #region Attributes
        public bool InsertIsSuccessful;
        public string ResponseMessage;
        #endregion

        public void FulfillStockList(DataTable dt)
        {
            //Prepare the StockWSDTO stock list
            StockWSDTO[] stock = new StockWSDTO[dt.Rows.Count];
            InsertIsSuccessful = true;
            ResponseMessage = string.Empty;

            //Fulfill the StockWSDTO with the DataTable
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StockWSDTO currentRow = new StockWSDTO();
                currentRow.item_cd = dt.Rows[i].ItemArray[2].ToString();
                currentRow.stock_qty = dt.Rows[i].ItemArray[4].ToString();

                stock[i] = currentRow;
            }
            
            //Prepare the request parameters
            StockWSPortTypeClient client = new StockWSPortTypeClient("StockWSHttpSoap12Endpoint");
            client.ClientCredentials.UserName.UserName = "dymosclsws01";
            client.ClientCredentials.UserName.Password = "dym0sc1sw$";

            //INSERT STOCK!!!
            StockWSDTO[] stockResp = client.InsertStockWS("EG13", stock);

            //Check the results
            StockWSDTO currentStockRow = new StockWSDTO();
            for (int i = 0; i < stockResp.Count(); i++)
            {
                currentStockRow = stockResp[i];
                if (currentStockRow.ret_code != "S")
                {
                    InsertIsSuccessful = false;
                    ResponseMessage = ResponseMessage + "Record: " + (i+1) +  " || Item ID: " + currentStockRow.item_cd + " - Error: " + currentStockRow.ret_msg + "\r\n";
                }
            }
        }
    }
}
