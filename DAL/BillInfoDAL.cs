﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;
        public static BillInfoDAL Instance
        {
            get { if (instance == null) instance = new BillInfoDAL(); return BillInfoDAL.instance; }
            private set { BillInfoDAL.instance = value; }
        }
        private BillInfoDAL() { }

        public List<BillInfo> GetListBillInfo()
        {
            List<BillInfo> list = new List<BillInfo>();
            string query = "SELECT * FROM BillInfo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                list.Add(billInfo);
            }
            return list;
        }

        public bool InsertAndUpdateBillInfo(int id_bill, string id_food, int quantity)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_Insert_UpdateBillInfo @idBill, @idFood, @count", new object[] { id_bill, id_food, quantity });
            return result > 0;
        }

        public bool UpdateBillInfo(int id_bill, string id_food, int quantity, int id)
        {
            string query = string.Format("UPDATE BillInfo SET id_bill={0}, id_food=N'{1}', amount={3} WHERE id={4}", id_bill, id_food, quantity, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteBillInfo(int id)
        {
            string query = string.Format("Delete from BillInfo WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<BillInfo> GetListByIdBill(int idBill)
        {
            List<BillInfo> list = new List<BillInfo>();
            string query = string.Format("SELECT * FROM BillInfo WHERE id_bill={0}", idBill);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                list.Add(billInfo);
            }
            return list;
        }
    }
}