
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XmlConfiguration;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
namespace employee
{
    public partial class Form1 : Form
    {
		int j;
		XmlNodeList phone_list ;
		XmlNodeList phones_list ;
		XmlNodeList name_list;
		XmlNodeList mail_list;
		XmlNodeList all;
		XmlNodeList addresses_list;
		XmlDocument doc;
		XmlNodeList address_list;
		XmlElement root;
		int index;
		string flag;
		string path = "contacts.xml";
		XmlElement employee ;
        XmlAttribute emp_id;
		XmlElement name ;
		XmlElement phones ;
		XmlElement phone;
		XmlAttribute Type;
		XmlElement addresses ;
		XmlElement address ;
		XmlElement street ;
		XmlElement buildingNumber ;
		XmlElement region ;
		XmlElement city ;
		XmlElement country ;
		XmlElement mail ;

		public Form1()
        {
            InitializeComponent();
			doc = new XmlDocument();
			doc.Load(path);
			root = doc.DocumentElement;
            j = 0;

        }


		private void button_prev_Click(object sender, EventArgs e)
		{
			if (j > 0)
			{
				empty_form();
				j--;
				if (j == 0)
				{
					button_prev.Enabled = false;
				}
				if (j < name_list.Count - 1)
				{
					button_next.Enabled = true;
				}
				fill_function();
			}
			
        }

        private void Form1_Load(object sender, EventArgs e)
        {
		    
			fill_function();
			if (j == 0)
			{
				button_prev.Enabled = false;
			}
			else
			{
				button_prev.Enabled = true;
			}

		}
		public void empty_form()
		{
			//
			listBox_street.Items.Clear();
			listBox_city.Items.Clear();
			listBox_region.Items.Clear();
			listBox_no.Items.Clear();
			listBox_country.Items.Clear();
			listBox_city.Items.Clear();
			listBox_home.Items.Clear();
			listBox_mobile.Items.Clear();
		}
		private void button_next_Click(object sender, EventArgs e)
		{
			
			button_prev.Enabled = true;
			empty_form();
			j++;
			if (j == (name_list.Count - 1))
			{
				button_next.Enabled = false;
			}
			fill_function();
			Refresh();
			
		}

		public void fill_function()
		{
			phones_list = doc.GetElementsByTagName("phones");
			phone_list = phones_list[j].ChildNodes;

			for (int i = 0; i < phone_list.Count; i++)
			{
				if (phone_list[i].Attributes[0].Value == "home")
				{
					listBox_home.Items.Add(phone_list[i].InnerText);
				}
				else if (phone_list[i].Attributes[0].Value == "mobile")
				{
					listBox_mobile.Items.Add(phone_list[i].InnerText);
				}
			}

			addresses_list = doc.GetElementsByTagName("addresses");
			address_list = addresses_list[j].ChildNodes;

			for (int i = 0; i < address_list.Count; i++)
			{
				listBox_street.Items.Add(address_list[i].ChildNodes[0].InnerText);
				listBox_no.Items.Add(address_list[i].ChildNodes[1].InnerText);
				listBox_region.Items.Add(address_list[i].ChildNodes[2].InnerText);
				listBox_city.Items.Add(address_list[i].ChildNodes[3].InnerText);
				listBox_country.Items.Add(address_list[i].ChildNodes[4].InnerText);
			}

		    name_list = doc.GetElementsByTagName("name");
			textBox_name.Text = name_list[j].InnerText;

		 

			 mail_list = doc.GetElementsByTagName("mail");
			textBox_mail.Text = mail_list[j].InnerText;
		}

		

		private void button_del_Click(object sender, EventArgs e)
		{
            //delete_button
            if (j > 0)
            {
                all = doc.GetElementsByTagName("employee");
                root = doc.DocumentElement;
                root.RemoveChild(all[j]);
                j--;
                empty_form();
                fill_function();
                doc.Save(path);
            }
            else
            {

                all = doc.GetElementsByTagName("employee");
                root = doc.DocumentElement;
                root.RemoveChild(all[j]);
                j=1;
                empty_form();
                fill_function();
                doc.Save(path);
            }

		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			if (button_update.Text == "update")
			{
				textBox_edit.Visible = true;
				label_edit.Visible = true;
				button_done.Visible = true;
				textBox_name.ReadOnly = false;
				textBox_mail.ReadOnly = false;
                button_update.Text = Text = "Save";
				button_cancel.Visible = true;
                button_next.Enabled = false;
                button_prev.Enabled = false;
                button_search.Enabled = false;
                button_insert.Enabled = false;
                button_del.Enabled = false;
				this.button_update.Location = new System.Drawing.Point(265, 310);
				button_cancel.Location = new System.Drawing.Point(140, 310);
			}

			else if (button_update.Text == "Save")
			{
                textBox_name.ReadOnly = true;
                textBox_mail.ReadOnly = true;
                textBox_edit.Visible = false;
                label_edit.Visible = false;
                button_done.Visible = false;
                this.button_update.Location = new System.Drawing.Point(200, 310);
                button_cancel.Visible = false;
                button_update.Text = "update";
                button_next.Enabled = true;
                button_prev.Enabled = true;
                button_search.Enabled =true;
                button_insert.Enabled = true;
                button_del.Enabled = true;
                name_list[j].InnerText = textBox_name.Text;
                mail_list[j].InnerText = textBox_mail.Text;
                phones_list = doc.GetElementsByTagName("phones");
                phone_list = phones_list[j].ChildNodes;
                phones_list[j].RemoveAll();
                addresses_list = doc.GetElementsByTagName("addresses");
                address_list = addresses_list[j].ChildNodes;
                addresses_list[j].RemoveAll();
                phone = doc.CreateElement("phone");
                Type = doc.CreateAttribute("Type");
                addresses = doc.CreateElement("addresses");
                address = doc.CreateElement("address");
                street = doc.CreateElement("street");
                buildingNumber = doc.CreateElement("buldingNumber");
                region = doc.CreateElement("region");
                city = doc.CreateElement("city");
                country = doc.CreateElement("country");
                for (int i=0;i<listBox_home.Items.Count;i++)
                {
                    Type.InnerText = "home";
                    phones_list[j].AppendChild(phone);
                    phone.Attributes.Append(Type);
                    phone.InnerText = listBox_home.Items[i].ToString();
                    doc.Save(path);
                }
                for (int i = 0; i < listBox_mobile.Items.Count; i++)
                {
                    Type.InnerText = "mobile";
                    phones_list[j].AppendChild(phone);
                    phone.Attributes.Append(Type);
                    phone.InnerText = listBox_mobile.Items[i].ToString();
                    doc.Save(path);
                }


                addresses_list = doc.GetElementsByTagName("addresses");
                address_list = addresses_list[j].ChildNodes;
                addresses_list[j].RemoveAll();


              
             doc.Save(path);
                }
                

            }
		

		private void button_done_Click(object sender, EventArgs e)
		{
			switch (flag)
			{
				case ("street"):
					listBox_street.Items[index] = textBox_edit.Text;
					listBox_street.SelectedIndex = listBox_street.Items.IndexOf(textBox_edit.Text);
                    flag = "";
					break;
				case ("region"):
					listBox_region.Items[index] = textBox_edit.Text;
                    listBox_region.SelectedIndex = listBox_region.Items.IndexOf(textBox_edit.Text);
                    textBox_edit.Text = "";
                    flag = "";
                    break;
                case ("bulding_no"):
                    listBox_no.Items[index] = textBox_edit.Text;
                    listBox_no.SelectedIndex = listBox_no.Items.IndexOf(textBox_edit.Text);
                    textBox_edit.Text = "";
                    flag = "";
                    break;
                case ("city"):
                    listBox_city.Items[index] = textBox_edit.Text;
                    listBox_city.SelectedIndex = listBox_city.Items.IndexOf(textBox_edit.Text);
                    textBox_edit.Text = "";
                    flag = "";
                    break;
                case ("country"):
                    listBox_country.Items[index] = textBox_edit.Text;
                    listBox_country.SelectedIndex = listBox_country.Items.IndexOf(textBox_edit.Text);
                    textBox_edit.Text = "";
                    flag = "";
                    break;
                case ("mobile"):
                    listBox_mobile.Items[index] = textBox_edit.Text;
                    listBox_mobile.SelectedIndex = listBox_mobile.Items.IndexOf(textBox_edit.Text);
                    textBox_edit.Text = "";
                    flag = "";
                    break;
                case ("home"):
                    listBox_home.Items[index] = textBox_edit.Text;
                    listBox_home.SelectedIndex = listBox_home.Items.IndexOf(textBox_edit.Text);
                    textBox_edit.Text = "";
                    flag = "";
                    break;
            }
		}

		private void listBox_street_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (flag != "street")
			{
				flag = "street";
				textBox_edit.Text = listBox_street.SelectedItem.ToString();
				index = listBox_street.SelectedIndex;
				
			}
		}

        private void listBox_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag != "bulding_no")
            { 
            flag = "bulding_no";
            index = listBox_no.SelectedIndex;
            textBox_edit.Text = listBox_no.SelectedItem.ToString();
            }
		}

		private void listBox_region_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (flag != "region")
            {
                flag = "region";
                index = listBox_region.SelectedIndex;
                textBox_edit.Text = listBox_region.SelectedItem.ToString();
            }
		}

        private void listBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag != "city")
            {
                flag = "city";
                index = listBox_city.SelectedIndex;
                textBox_edit.Text = listBox_city.SelectedItem.ToString();
            }
        }
        private void listBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag != "country")
            {
                flag = "country";
                index = listBox_country.SelectedIndex;
                textBox_edit.Text = listBox_country.SelectedItem.ToString();
            }
        }
        private void listBox_mobile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag != "mobile")
            {
                flag = "mobile";
                index = listBox_mobile.SelectedIndex;
                textBox_edit.Text = listBox_mobile.SelectedItem.ToString();
            }
        }

        private void listBox_home_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag != "home")
            {
                flag = "home";
                index = listBox_home.SelectedIndex;
                textBox_edit.Text = listBox_home.SelectedItem.ToString();
            }
        }
		private void button_cancel_Click(object sender, EventArgs e)
		{
			button_update.Text = "update";
			button_cancel.Visible = false;
			button_update.Location = new System.Drawing.Point(200, 310);
			textBox_name.ReadOnly = true;
			textBox_mail.ReadOnly = true;
			textBox_edit.Visible = false;
			label_edit.Visible = false;
			button_done.Visible = false;
            button_prev.Enabled = true;
            button_update.Enabled = true;
            button_next.Enabled = true;
            button_insert.Enabled = true;
            button_del.Enabled = true;
            button_search.Enabled = true;
		}

		private void button_insert_Click_1(object sender, EventArgs e)
		{
            int id = name_list.Count + 1;
			panel_insert.Visible = true;
			if (button_insert.Text == "insert")
			{

				button_update.Enabled = false;
				button_search.Enabled = false;
				button_prev.Enabled = false;
				button_next.Enabled = false;
				button_del.Enabled = false;
				button_insert.Text = "Save";
				textBox_name.Text = "";
				textBox_mail.Text = "";
				textBox_name.ReadOnly = false;
				textBox_mail.ReadOnly = false;

				employee = doc.CreateElement("employee");
                emp_id = doc.CreateAttribute("id");
				name = doc.CreateElement("name");
				phones = doc.CreateElement("phones");
				phone = doc.CreateElement("phone");
				Type = doc.CreateAttribute("Type");
				addresses = doc.CreateElement("addresses");
				address = doc.CreateElement("address");
				street = doc.CreateElement("street");
				buildingNumber = doc.CreateElement("buldingNumber");
				region = doc.CreateElement("region");
				city = doc.CreateElement("city");
				country = doc.CreateElement("country");
				mail = doc.CreateElement("mail");

				//name.InnerText = textBox_name.Text;
				//street.InnerText = richTextBox_street.Text;
				//region.InnerText = richTextBox_region.Text;
				//buildingNumber.InnerText = richTextBox_no.Text;
				//city.InnerText = richTextBox_city.Text;
				//country.InnerText = richTextBox_country.Text;
				//mail.InnerText = textBox_mail.Text;
				//phone.Attributes.Append(Type);

			}
			else
			{
				button_update.Enabled = true;
				button_search.Enabled = true;
				button_prev.Enabled = true;
				button_next.Enabled = true;
				button_del.Enabled = true;
				
				root.AppendChild(employee);
                emp_id.InnerText = id.ToString();
                employee.Attributes.Append(emp_id);
				employee.AppendChild(name);
				if (textBox_name.Text !="")
				{
					name.InnerText = textBox_name.Text;
				}
				else
				{
					name.InnerText = "no_name";
				}

				employee.AppendChild(phones);
				
				if (textBox_home.Text != "")
				{
					phone = doc.CreateElement("phone");
					Type = doc.CreateAttribute("Type");
					phones.AppendChild(phone);
					phone.InnerText = textBox_home.Text;
					Type.InnerText = "home";
					phone.Attributes.Append(Type);
				}
				else
				{
					phones.AppendChild(phone);
					phone.InnerText = "-";
					Type.InnerText = "home";
					phone.Attributes.Append(Type);
				}

				if (textBox_mobile.Text != "")
				{
					phone = doc.CreateElement("phone");
					Type = doc.CreateAttribute("Type");
					phones.AppendChild(phone);
					phone.InnerText = textBox_mobile.Text;
					Type.InnerText = "mobile";
					phone.Attributes.Append(Type);
				}
				else
				{
					phone = doc.CreateElement("phone");
					Type = doc.CreateAttribute("Type");
					phones.AppendChild(phone);
					phone.InnerText = "-";
					Type.InnerText = "mobile";
					phone.Attributes.Append(Type);
				}

				employee.AppendChild(addresses);
				address = doc.CreateElement("address");
				addresses.AppendChild(address);
				if (richTextBox_street.Text != "")
				{
					street = doc.CreateElement("street");
					street.InnerText = richTextBox_street.Text;
				}
				else
				{
					street = doc.CreateElement("street");
					street.InnerText = "_";
				}
				if (richTextBox_region.Text != "")
				{
					region = doc.CreateElement("region");
					region.InnerText = richTextBox_region.Text;
				}
				else
				{
					region = doc.CreateElement("region");
					region.InnerText = "_";
				}
				if (richTextBox_no.Text != "")
				{
					buildingNumber = doc.CreateElement("buldingNumber");
					buildingNumber.InnerText = richTextBox_no.Text;
				}
				else
				{
					buildingNumber = doc.CreateElement("buldingNumber");
					buildingNumber.InnerText = "_";
				}
				if (richTextBox_city.Text != "")
				{
					city = doc.CreateElement("city");
					city.InnerText = richTextBox_city.Text;
				}
				else
				{
					city = doc.CreateElement("city");
					city.InnerText = "_";
				}
				if (richTextBox_country.Text != "")
				{
					country = doc.CreateElement("country");
					country.InnerText = richTextBox_country.Text;
				}
				else
				{
					country = doc.CreateElement("country");
					country.InnerText = "_";
				}

				address.AppendChild(street);
				address.AppendChild(buildingNumber);
				address.AppendChild(region);
				address.AppendChild(city);
				address.AppendChild(country);

				employee.AppendChild(mail);
				if (textBox_mail.Text != "")
				{
					mail.InnerText = textBox_mail.Text;
				}
				else
				{
					mail.InnerText = "-";
				}

				doc.Save(path);
				panel_insert.Visible = false;
				listBox_city.Items.Clear();
				listBox_country.Items.Clear();
				listBox_mobile.Items.Clear();
				listBox_home.Items.Clear();
				listBox_no.Items.Clear();
				listBox_region.Items.Clear();
				listBox_street.Items.Clear();
				j = name_list.Count-1;
				fill_function();
				button_insert.Text = "insert";
				button_next.Enabled = false;

			}

		}

		private void button_phone_Click(object sender, EventArgs e)
		{

			if (textBox_home.Text != "")
			{
				phone = doc.CreateElement("phone");
				Type = doc.CreateAttribute("Type");
				phones.AppendChild(phone);
				phone.InnerText = textBox_home.Text;
				Type.InnerText = "home";
				phone.Attributes.Append(Type);
			}
			else
			{
				phone = doc.CreateElement("phone");
				Type = doc.CreateAttribute("Type");
				phones.AppendChild(phone);
				
				phone.InnerText = "-";
				Type.InnerText = "home";
				phone.Attributes.Append(Type);
			}

			if (textBox_mobile.Text != "")
			{
				phone = doc.CreateElement("phone");
				Type = doc.CreateAttribute("Type");
				phones.AppendChild(phone);
				
				phone.InnerText = textBox_mobile.Text;
				Type.InnerText = "mobile";
				phone.Attributes.Append(Type);
			}
			else
			{
				phone = doc.CreateElement("phone");
				Type = doc.CreateAttribute("Type");
				phones.AppendChild(phone);
				phone.InnerText = "-";
				Type.InnerText = "mobile";
				phone.Attributes.Append(Type);
			}

			textBox_home.Text = "";
			textBox_mobile.Text = "";
		}

		private void button_address_Click(object sender, EventArgs e)
		{
			address = doc.CreateElement("address");
			
			
			if (richTextBox_street.Text != "")
			{
				street = doc.CreateElement("street");
				street.InnerText = richTextBox_street.Text;
				address.AppendChild(street);
			}
			else
			{
				street = doc.CreateElement("street");
				street.InnerText = "_";
				address.AppendChild(street);
			}
			if (richTextBox_region.Text != "")
			{
				region = doc.CreateElement("region");
				region.InnerText = richTextBox_region.Text;
				address.AppendChild(region);
			}
			else
			{
				region = doc.CreateElement("region"); 
				region.InnerText = "_";
				address.AppendChild(region);
			}
			if (richTextBox_no.Text != "")
			{
				buildingNumber = doc.CreateElement("buldingNumber");
				buildingNumber.InnerText = richTextBox_no.Text;
				address.AppendChild(buildingNumber);
			}
			else
			{
				buildingNumber = doc.CreateElement("buldingNumber");
				buildingNumber.InnerText = "_";
				address.AppendChild(buildingNumber);
			}
			if (richTextBox_city.Text != "")
			{
				city = doc.CreateElement("city");
				city.InnerText = richTextBox_city.Text;
				address.AppendChild(city);
			}
			else
			{
				city = doc.CreateElement("city"); 
				city.InnerText = "_";
				address.AppendChild(city);
			}
			if (richTextBox_country.Text != "")
			{
				country = doc.CreateElement("country");
				country.InnerText = richTextBox_country.Text;
				address.AppendChild(country);
			}
			else
			{
				country = doc.CreateElement("country");
				country.InnerText = "_";
				address.AppendChild(country);
			}
			addresses.AppendChild(address);
			richTextBox_street.Text = "";
			richTextBox_no.Text = "";
			richTextBox_region.Text = "";
			richTextBox_city.Text = "";
			richTextBox_country.Text = "";
		}



		private void button_view1_Click(object sender, EventArgs e)
		{
			XslCompiledTransform xslt = new XslCompiledTransform();
			xslt.Load("contacts.xsl");
			xslt.Transform("contacts.xml", "contacts.html");
			System.Diagnostics.Process.Start("contacts.html");

			
		}



		private void button_view2_Click_1(object sender, EventArgs e)
		{
			
				XslCompiledTransform xslt = new XslCompiledTransform();
				xslt.Load("contacts1.xsl");
				xslt.Transform("contacts.xml", "contacts1.html");
				System.Diagnostics.Process.Start("contacts1.html");
		
		}

		private void button_view3_Click(object sender, EventArgs e)
		{
			XslCompiledTransform xslt = new XslCompiledTransform();
			xslt.Load("contacts2.xsl");
			xslt.Transform("contacts.xml", "contacts2.html");
			System.Diagnostics.Process.Start("contacts2.html");
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
            string xml_data = doc.InnerXml;
            string connection = @"Data Source=MADONNA-PC\MADONNA;Initial Catalog=contacts;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("xmlsave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@doc",xml_data);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            searchDialgueBox dg = new searchDialgueBox();
            DialogResult d = dg.ShowDialog();
            if (d==DialogResult.OK)
            {
                j = int.Parse(dg.Id)-1;
                fill_function();
                if(j!=0)
                {
                    button_prev.Enabled = true;
                }

            }
        }
    }
}



