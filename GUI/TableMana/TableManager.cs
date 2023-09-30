﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.TableMana
{
    public partial class TableManager : Form
    {
        private bool isButtonPressed = false;
        public TableManager()
        {
            InitializeComponent();
            loadData();
            btnDelTable.Enabled = false;
        }

        void loadData()
        {
            List<Table> listTable = TableBLL.Instance.GetListTable();

            foreach (Table item in listTable)
            {
                Button btn = new Button() { Width = 129, Height = 100 };
                btn.Text = item.TableName + Environment.NewLine + item.StatusTable;
                btn.Tag = item;
                // Hiển thị trạng thái dưới dạng chuỗi
                string statusText = (item.StatusTable == 0) ? "Trống" : "Có khách";

                // Gán text cho button
                btn.Text = item.TableName + Environment.NewLine + statusText;
                btn.Tag = item;

                // Thay đổi màu nền dựa trên trạng thái
                btn.BackColor = (item.StatusTable == 0) ? Color.White : Color.Red;

                // Thêm sự kiện Click cho button
                btn.Click += Btn_Click;

                flowTable.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                if (isButtonPressed)
                {
                    clickedButton.BackColor = Color.White;
                }
                else
                {
                    clickedButton.BackColor = Color.LightGreen;
                }

                // Cập nhật trạng thái
                isButtonPressed = !isButtonPressed;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {
            DeleteSelectedTable();
        }

        private void DeleteSelectedTable()
        {
            // Duyệt qua các control trong flowLayoutPanel để tìm nút đã được chọn
            foreach (Control control in flowTable.Controls)
            {
                if (control is Button button)
                {
                    if (button.BackColor == Color.LightGreen) // Nút đã được chọn
                    {
                        // Lấy thông tin bàn từ Tag của nút
                        Table table = button.Tag as Table;

                        // Xử lý xóa bàn ở đây (ví dụ: gọi hàm BLL để xóa bàn)
                        // Ví dụ: TableBLL.Instance.DeleteTable(table);

                        // Sau khi xóa, cập nhật giao diện
                        flowTable.Controls.Remove(button);
                        break; // Chỉ xóa một bàn đầu tiên được chọn
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}