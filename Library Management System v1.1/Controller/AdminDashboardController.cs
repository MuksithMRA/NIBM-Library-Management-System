using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Windows;
using System.Reflection;
using Axis = LiveCharts.Wpf.Axis;

namespace Library_Management_System_v1._1.Controller
{
    class AdminDashboardController
    {
        static Model.DatabaseService database = new Model.DatabaseService();
        static public int memberCount = 0;

        public static void loadLibrariyanList(MaterialListView listView , MaterialLabel NOF)
        {
            listView.Items.Clear();
            try
            {
                database.Con.Open();
                MySqlDataReader sdr = database.readData("Select * From Librarian");
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        ListViewItem item = new ListViewItem(sdr["Librarian_Id"].ToString());
                        item.SubItems.Add(sdr["Name"].ToString());
                        item.SubItems.Add(sdr["Address"].ToString());
                        item.SubItems.Add(sdr["Phone"].ToString());
                        item.SubItems.Add(sdr["NIC"].ToString());
                        item.SubItems.Add(sdr["updated_date"].ToString());

                        listView.Items.Add(item);
                    }
                    database.Con.Close();
                    NOF.Text = listView.Items.Count.ToString();
                    

                }
                else
                {
                    Console.WriteLine("No Data to Show");
                    database.Con.Close();
                }

            }
            catch (MySqlException ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
                database.Con.Close();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                database.Con.Close();
            }

        }

        //=============Search Function ==========================

        public void searchFunction(MaterialListView list, int itemIndex, MaterialTextBox inputBox)
        {
          
                if (itemIndex == 0)
                {

                    for (int i = list.Items.Count - 1; i >= 0; i--)
                    {
                        var item = list.Items[i];

                        if (item.Text.ToLower().Contains(inputBox.Text.ToLower()))
                        {

                        }
                        else
                        {
                            list.Items.Remove(item);
                        }
                    }
                    if (list.SelectedItems.Count == 1)
                    {
                        list.Focus();
                    }
                }
                else if(itemIndex == 1)
                {
                    for (int i = list.Items.Count - 1; i >= 0; i--)
                    {
                        var item = list.Items[i];

                        if (item.SubItems[1].Text.ToLower().Contains(inputBox.Text.ToLower()))
                        {

                        }
                        else
                        {
                            list.Items.Remove(item);
                        }
                    }
                    if (list.SelectedItems.Count == 1)
                    {
                        list.Focus();
                    }

                }
                else
                {

                }

        }

        //=============Set Notification Count Label==============
        public String setNotificationCount()
        {
            try
            {
                database.Con.Open();
                MySqlDataReader sdr = database.readData("Select * FROM Notification WHERE Status = ''");
                int count = 0;
                while (sdr.Read())
                {
                    count = count + 1;
                }

                database.Con.Close();
                return count.ToString();
            }catch(MySqlException ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                
            }catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            finally
            {
                database.Con.Close();
            }
            return "";
        }

        //============Set Admin Name ============================
        public String setName(String emp_id)
        {
            try
            {
                database.Con.Open();
                MySqlDataReader sdr = database.readData("Select Name From Admin WHERE emp_id = '" + emp_id + "'");
                sdr.Read();
                String name =  sdr["Name"].ToString();
                database.Con.Close();
                return name;
            }
            catch (MySqlException ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
            finally
            {
                database.Con.Close();
            }
            return "";
        }


        //=========================Chart Codes========================================
        
        public static List<Model.BarChartModel> getBarchartData()
        {
            List<Model.BarChartModel> barchartData = new List<Model.BarChartModel>();
            database.Con.Open();
            MySqlDataReader sdr = database.readData("SELECT Count(*), DAY(Date_Added) FROM Member WHERE Month(Date_Added) = '"+DateTime.Now.Month+"' GROUP BY DAY(Date_Added)");
            while (sdr.Read())
            {
                if (sdr.HasRows)
                {
                    int AxisXDay = Convert.ToInt32(sdr["Count(*)"]);
                    int AxisYMemberCount = Convert.ToInt32( sdr["DAY(Date_Added)"]);
                    barchartData.Add(new Model.BarChartModel(AxisXDay, AxisYMemberCount ));
                    memberCount = memberCount + AxisXDay;
                }
            }
            database.Con.Close();
            return barchartData;
        }
        public static void  loadCartChart(LiveCharts.WinForms.CartesianChart chart)
        {
           
            try
            {
                List<Model.BarChartModel> barchartData = getBarchartData();
                //Create columns chart
                ColumnSeries col = new ColumnSeries()
                {
                    Title = "Member Count",
                    
                    DataLabels = true,
                    Values = new ChartValues<int>(),
                    LabelPoint = point => point.Y.ToString()
                    
                };
                Axis ax = new Axis()
                {
                    Separator = new Separator()
                    {
                        Step = 1,
                        IsEnabled = false
                        
                    }
                };
                ax.Labels = new List<string>();
                if (barchartData.Count > 0)
                {
                    //Add data to your chart
                    foreach (var x in barchartData)
                    {
                        col.Values.Add(x.ValueX);
                        ax.Labels.Add(x.ValueY.ToString());
                    }
                    chart.Series.Clear();
                    chart.AxisX.Clear();
                    chart.AxisY.Clear();
                    chart.Series.Add(col);
                    chart.AxisX.Add(ax);
                    chart.AxisY.Add(new Axis
                    {
                        LabelFormatter = value => value.ToString(),
                        Separator = new Separator()
                    });
                }
                else
                {
                    Console.WriteLine("No Data");
                }
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                database.Con.Close();
            }
        
        }

        public void loadCategoriesPieChart(LiveCharts.WinForms.PieChart pieChart)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            Model.DatabaseService database = new Model.DatabaseService();

            LiveCharts.SeriesCollection piechartData = new LiveCharts.SeriesCollection();
            List<System.Windows.Media.Brush> colors = new List<System.Windows.Media.Brush>();
            colors.Add(System.Windows.Media.Brushes.Fuchsia);
            colors.Add(System.Windows.Media.Brushes.DarkViolet);
            colors.Add(System.Windows.Media.Brushes.BlueViolet);
            colors.Add(System.Windows.Media.Brushes.CornflowerBlue);
            colors.Add(System.Windows.Media.Brushes.Cyan);
            colors.Add(System.Windows.Media.Brushes.Azure);
            colors.Add(System.Windows.Media.Brushes.Brown);
            int i = 0;
            try
            {

                List<Model.PiechartDataModel> piechartItems = setPiechartData();
                if (piechartItems.Count > 0)
                {
                    
                    foreach(Model.PiechartDataModel mod in piechartItems)
                    {
                        
                        piechartData.Add(
                            new PieSeries
                            {
                                Title = mod.Name,
                                Values = new ChartValues<double> {Math.Round(mod.Percentage,2)},
                                DataLabels = true,
                                LabelPoint = labelPoint,
                                Fill = colors[i],
                            }
                        );
                        i++;
                    }
                }
            }catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

            // Define the collection of Values to display in the Pie Chart
            pieChart.Series = piechartData;

            // Set the legend location to appear in the bottom of the chart
            pieChart.LegendLocation = LegendLocation.Right;
        }

       

        //===================Get Category Count ===================

        public int setBookCount()
        {
            int a = 0;
            Model.DatabaseService database = new Model.DatabaseService();
            
             database.Con.Open();
             MySqlCommand cmd = new MySqlCommand("SELECT Count(*) FROM Book", database.Con);
             a = Convert.ToInt32( cmd.ExecuteScalar().ToString());
             database.Con.Close();
            return a;
        }

        

        //============== set Piechart Data ==================================
        public List<Model.PiechartDataModel> setPiechartData()
        {
            Model.DatabaseService database = new Model.DatabaseService();
            List<Model.PiechartDataModel> piechartItems = new List<Model.PiechartDataModel>();
            database.Con.Open();
            MySqlDataReader sdr = database.readData("SELECT * FROM Category");
            while (sdr.Read())
            {   
                double bookCount = Convert.ToDouble(sdr["Book_Count"]);
                if (bookCount > 0)
                {
                    piechartItems.Add(new Model.PiechartDataModel(sdr["Category_Name"].ToString(), bookCount));
                } 
            }
            database.Con.Close();
            return piechartItems;
        }

    }
}
