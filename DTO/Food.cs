﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class Food
    {
        /**
         * Class Food
         * stt INT 
         * id VARCHAR(20)
         * food_name NVARCHAR(100)
         * id_category INT
         * price Float
         */
        private string id, food_name;
        private int stt, id_category;
        private float price;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Stt
        {
            get { return stt; }
            set { stt = value; }
        }
        public int Id_Category
        {
            get { return id_category; }
            set { id_category = value; }
        }
        public string Food_Name
        {
            get { return food_name; }
            set { food_name = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public Food(int stt, string id, string name, int categoryId, float price)
        {
            this.Stt = stt;
            this.Id = id;
            this.Food_Name = name;
            this.Id_Category = categoryId;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.Id = (string)row["id"];
            this.Food_Name = row["name"].ToString();
            this.Id_Category = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        
    }
}
