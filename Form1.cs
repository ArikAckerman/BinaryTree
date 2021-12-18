using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
            "Бетховен",
            "Бах",
            "Бабах",
            "Филиппов",
            "Панченко",
            "Корж",
            "Веселов",
            "Розова",
            "Жигалкин",
            "Ульянов",
            "Метелев"
        };
            AddDiller.AutoCompleteCustomSource = source;
            AddDiller.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AddDiller.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static string[] FIO = { };
        BinaryTree SomeOne = new BinaryTree();
        public BinaryTree.Diller DazADiller = new BinaryTree.Diller();
        #region Tree
        public class BinaryTree
        {
            public string Root; // значение корня
            public BinaryTree LeftChild, RightChild; // указатели на потомков
            

            public BinaryTree()
            { }
             

            public BinaryTree(string Root)
            {
                this.Root = Root;
            }
            
            public int CompareTo(string Data) // Сравнение со «String»
            {
                if (string.Compare(this.Root, Data) == 1) return 1;
                if (string.Compare(this.Root, Data) == -1) return -1;
                else return 0;
            }
            public bool Insert(string value)
            {
                if (this.Root == null)
                {
                    
                    this.Root = value;
                    return true;
                }
                else
                if ((this.Root).CompareTo(value) == 1)
                {
                    if (LeftChild == null)
                        this.LeftChild = new BinaryTree();
                    return LeftChild.Insert(value);
                }
                else
                if ((this.Root).CompareTo(value) == -1)
                {
                    if (RightChild == null)
                        this.RightChild = new BinaryTree();
                    return RightChild.Insert(value);
                }
                else
                    return false;
            }
            // поиск
            public BinaryTree Search(string value)
            {
                if (!IsEmpty())
                    if ((this.Root).CompareTo(value) == 1)
                        if (LeftChild != null)
                            return this.LeftChild.Search(value);
                        else
                            return (null);
                    else
                    if ((this.Root).CompareTo(value) == -1)
                        if (RightChild != null)
                            return this.RightChild.Search(value);
                        else
                            return (null);
                    else return this;
                else
                    return (null);
            }

            public bool IsEmpty()
            {
                if (this.Root == null)
                    return true;
                else
                    return false;
            }
            // удаление элемента
            public bool Delete(string value)
            {
                BinaryTree Node = new BinaryTree();
                if (Search(value) != null)
                    if (this.Root != null)
                        if ((this.Root).CompareTo(value) == 1 && LeftChild != null) // <
                            return LeftChild.Delete(value);
                        else
                        if ((this.Root).CompareTo(value) == -1 && RightChild != null) // >
                            return RightChild.Delete(value);
                        else // =
                        {
                            if (LeftChild == null && RightChild == null)
                                this.Root = null;
                            else
                            if (LeftChild != null)
                                if (RightChild == null)
                                {
                                    Node = this.LeftChild;
                                    this.Root = Node.Root;
                                    LeftChild = Node.LeftChild;
                                    RightChild = Node.RightChild;
                                }
                                else
                                {
                                    Node = RightChild;
                                    if (Node.LeftChild != null)
                                    {
                                        while (Node.LeftChild.LeftChild != null)
                                            Node = Node.LeftChild;
                                        this.Root = Node.LeftChild.Root;
                                        if (Node.LeftChild.RightChild == null)
                                            Node.LeftChild = null;
                                        else
                                            Node.LeftChild = Node.LeftChild.RightChild;
                                    }
                                    else
                                    {
                                        this.Root = Node.Root;
                                        this.RightChild = Node.RightChild;
                                    }
                                }
                            else
                            {
                                Node = RightChild;
                                this.Root = Node.Root;
                                LeftChild = Node.LeftChild;
                                RightChild = Node.RightChild;
                            }
                            return true;
                        }
                    else return false;
                else return false;
            }

            public void Dispose()
            {
                if (this.Root != null)
                {
                    if (LeftChild != null)
                        LeftChild.Dispose();
                    if (RightChild != null)
                        RightChild.Dispose();
                    this.LeftChild = null;
                    this.RightChild = null;
                    this.Root = null;
                }
            }

            #region Diller
            public class Diller
            {
                public string DrugDiller;
                public string PhoneNum { get; set; }
                public string Email { get; set; }
                public string Discount { get; set; }
                public string Purchases { get; set; }
                public string Sales { get; set; }
                public string Address { get; set; }

                public Diller()
                {

                }

                public Diller(string DrugDiller, string PhoneNum, string Address, string Email, string Discount, string Purchases, string Sales)
                {
                    this.DrugDiller = DrugDiller;
                    this.PhoneNum = PhoneNum;
                    this.Address = Address;
                    this.Email = Email;
                    this.Discount = Discount;
                    this.Purchases = Purchases;
                    this.Sales = Sales;
                }
                public string Name_OutPut // cвойство для получения FIO
                {
                    get
                    {
                        return this.DrugDiller;
                    }
                    set
                    {
                        DrugDiller = value;
                    }
                }


                public int CompareTo(string Data) // Сравнение со «String»
                {
                    if (string.Compare(this.DrugDiller, Data) == 1) return 1;
                    if (string.Compare(this.DrugDiller, Data) == -1) return -1;
                    else return 0;
                }
            }
            #endregion Diller

        }
        #endregion Tree


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void AddDrugDiller_Click_1(object sender, EventArgs e)
        {
            if (AddDiller.Text != "")
            {
                if (SomeOne.Insert(AddDiller.Text))
                {
                    DataList.Items.Add("Элемент " + AddDiller.Text + " добавлен");
                }
                else
                    DataList.Items.Add("Элемент " + AddDiller.Text + " уже существует");
                AddDiller.Text = "";
            }
            else MessageBox.Show("Введите элемент");

        }

            private void Adress_TextChanged(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void DiscountVal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }


        private void Delete_Click(object sender, EventArgs e)
        {
            if (clear.Text != "")
            {
                if (SomeOne.Delete(clear.Text))
                {
                    DataList.Items.Add("Элемент " + clear.Text + " удален");
                }
                else
                    DataList.Items.Add("Элемента " + clear.Text + " нет в дереве");
                clear.Text = "";
            }
            else MessageBox.Show("Введите элемент");
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            if (SearchDiller.Text != "")
            {
                if (SomeOne.Search(SearchDiller.Text) != null)
                {
                    DataList.Items.Add("Элемент " + SomeOne.Search(SearchDiller.Text).Root + " найден");
                    DillerInfo.Items.Add("Данные о " + SomeOne.Root +": ");
                    DillerInfo.Items.Add("Номер телефона: " + DazADiller.PhoneNum);
                    DillerInfo.Items.Add("Адрес: " + DazADiller.Address);
                }
                else
                {
                    DataList.Items.Add("Элемент " + SearchDiller.Text + " не найден");
                }
                    clear.Text = "";
                    SearchDiller.Text = "";
                
            }
            else MessageBox.Show("Введите элемент");
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            if (adress.Text != "")
            {
                    if (DazADiller.Address == null)
                    {
                        DazADiller.Address = adress.Text;
                        DataList.Items.Add("Адрес " + SomeOne.Root + ": " + DazADiller.Address);
                    }
                    else
                    {
                        DataList.Items.Add("Адрес данного дилера уже существует");
                    }

            }
            else MessageBox.Show("Введите адрес");
            if (phonenum.Text != "")
            {
                if (DazADiller.PhoneNum == null)
                {
                    DazADiller.PhoneNum = phonenum.Text;
                    DataList.Items.Add("Номер телефона" + SomeOne.Root + ": " + DazADiller.PhoneNum);
                }
                else
                {
                    DataList.Items.Add("Номер телефона для данного дилера уже внесен");
                }
            }
            else MessageBox.Show("Введите номер");

        }
    }
    
}
