using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookListView
{
    public partial class frmBooks : Form
    {

        string[] b_name = { "三國演義", "西遊記","唐詩三百首","楚辭","西廂記","水滸傳","紅樓夢", "牡丹亭" }; //書名
        string[] author = {"羅貫中", "吳承恩", "孫洙", "劉向","王實甫","施耐庵", "曹雪芹", "湯顯祖" }; //作者
        string[] kind = { "章回小說", "章回小說", "詩選", "詩歌", "戲曲","章回小說","章回小說", "戲曲" }; //類別
        public frmBooks()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbView.Items.Add("大圖示");
            cmbView.Items.Add("詳細資料");
            cmbView.Items.Add("小圖示");
            cmbView.Items.Add("清單");
            cmbView.Items.Add("大圖示加詳細資料");
            cmbView.SelectedIndex = 0; //預設選取第一個項目
            lvwBooks.Columns.Add("書名", 100); //新增 書名 欄位，寬度為100
            lvwBooks.Columns.Add("作者", 60); //新增 作者 欄位，寬度為60
            lvwBooks.Columns.Add("類別", 60); //新增 類別 欄位
            lvwBooks.BeginUpdate(); //暫停重繪
            for (int i = 0; i < b_name.Length; i++)
            { //宣告一個ListViewItem物件
                ListViewItem lvi = new ListViewItem(b_name[i]);
                lvi.SubItems.Add(author[i].ToString()); //新增 作者 欄位資料
                lvi.SubItems.Add(kind[i]); //新增 類別 欄位資料
                lvwBooks.Items.Add(lvi); //新增項目
                lvwBooks.Items[i].ImageIndex = i; //指定影像的索引值
            }
            lvwBooks.EndUpdate(); //重繪;

            lvwBorrow.Columns.Add("書名", 100); //新增 書名 欄位，寬度為100
            lvwBorrow.Columns.Add("借閱日期", 100);
            lvwBorrow.Columns.Add("歸還日期", 100);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pnlTools_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvwBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            

            if (lvwBooks.SelectedIndices.Count > 0)
            {
                string strBookname = b_name[lvwBooks.SelectedIndices[0]];
                DateTime selectedDate = borrowdate.Value.Date; // 目前選取的日期

                bool isAlreadyBorrowed = false;

                // 遍歷借書清單 lvwBorrow 進行比對
                foreach (ListViewItem item in lvwBorrow.Items)
                {
                    // 1. 先確認書名是否相同
                    if (item.Text == strBookname)
                    {
                        DateTime existingStartDate = DateTime.Parse(item.SubItems[1].Text).Date;
                        DateTime existingDueDate = DateTime.Parse(item.SubItems[2].Text).Date;


                        DateTime newStartDate = selectedDate;
                        DateTime newDueDate = selectedDate.AddDays(6);

                        if (!(newStartDate < existingStartDate && newDueDate < existingStartDate) && !(newStartDate > existingDueDate && newDueDate > existingDueDate)) {
                            isAlreadyBorrowed = true;
                            break; // 只要找到一筆重疊的紀錄，就中斷檢查
                        }
                    }
                }

                if (isAlreadyBorrowed)
                {
                    MessageBox.Show($"「{strBookname}」在此日期區間 (至 7 天內) 已被借閱，請選擇其他日期或書籍。", "無法借閱");
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"確定要借閱「{strBookname}」嗎？\n借閱日期：{selectedDate.ToString("yyyy/MM/dd")}", "借書確認", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        // 計算到期日 (含當天共 7 天，所以加 6 天)
                        DateTime startDate = selectedDate.Date;
                        DateTime dueDate = selectedDate.AddDays(6);

                        lvwBorrow.BeginUpdate();
                        ListViewItem lvi = new ListViewItem(strBookname);
                        lvi.SubItems.Add(startDate.ToString("yyyy/MM/dd"));
                        lvi.SubItems.Add(dueDate.ToString("yyyy/MM/dd"));
                        lvwBorrow.Items.Add(lvi);
                        lvwBorrow.EndUpdate();
                    }
                }
            }
        }

        private void lvwBorrow_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBorrow.SelectedIndices.Count > 0)
            {
                int index = lvwBorrow.SelectedIndices[0]; 
                string bookName = lvwBorrow.Items[index].Text; 

                 DialogResult dr = MessageBox.Show($"確定要歸還「{bookName}」嗎?", "還書確認", MessageBoxButtons.YesNo);
        
                if (dr == DialogResult.Yes)
                {
                    lvwBorrow.Items.RemoveAt(index);
                }
                else if(dr == DialogResult.No) {
                
                    // 點選「否」的情況
                    lvwBorrow.SelectedItems[0].Selected = false; // 手動取消選取，讓下次點擊能重新觸發
                }

                lvwBorrow.Focus(); // 強制讓 ListView 拿回焦點
                return;
            }
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根據cmbView的SelectedIndex屬性值，設定檢視方式
            switch (cmbView.SelectedIndex)
            {
                case 0: //大圖示
                    lvwBooks.View = View.LargeIcon;
                    break;
                case 1: //詳細資料
                    lvwBooks.View = View.Details;
                    break;
                case 2: //小圖示
                    lvwBooks.View = View.SmallIcon;
                    break;
                case 3: //清單
                    lvwBooks.View = View.List;
                    break;
                case 4: //大圖示加詳細資料
                    lvwBooks.View = View.Tile;
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lvwBorrow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
