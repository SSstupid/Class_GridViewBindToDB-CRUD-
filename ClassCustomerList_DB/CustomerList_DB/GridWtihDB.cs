using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CustomerList_DB
{
    public class GridWithDB
    {
        private static String _server = "localhost";
        private static String _port = "3306";
        private static String _database = "test";
        private static String _user = "root";
        private static String _password = "1234";

        public static DataGridView dataGridView = new DataGridView();
        private static string _tableName = "cuslist";
        
        DataTable dataTable = new DataTable();
        MySqlDataReader myReader;

        private static string ServerInfo = string.Format("Server={0};Port={1};Database={2};Uid ={3};Pwd={4};",
                                                    _server, _port, _database, _user, _password);

        //연결할 DB정보 입력
        public GridWithDB(string Server, string Port, string Database, string User, string Password)
        {
            _server = Server;
            _port = Port;
            _database = Database;
            _user = User;
            _password = Password;
        }

        public GridWithDB() // Default
        {
        }

        //바인드할 GridView, Table 이름 
        public void SetGridTable(DataGridView DataGridView, string TableName)
        {
            dataGridView = DataGridView;
            _tableName = TableName;
        }

        //Gridview Datatable 바인딩 => GridView에 DB_Data 가져오기
        public void GetDataDB()
        {
            using (MySqlConnection conn = new MySqlConnection(ServerInfo))
            {
                try
                {
                    conn.Open();
                    string Query = $"SELECT * FROM {_tableName};";
                    dataTable.Clear();

                    var adapt = new MySqlDataAdapter(Query, conn);

                    adapt.Fill(dataTable);
                    dataGridView.DataSource = dataTable;

                    dataGridView.Columns["FirstName"].Visible = false;
                    dataGridView.Columns["LastName"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message);
                }
            }
        }

        //검색 필터 Filter
        public void GetDataDB(string No) // 선택한 Table을 listview에 출력
        {
            using (MySqlConnection conn = new MySqlConnection(ServerInfo))
            {
                try
                {
                    string Query = $"SELECT * FROM {_tableName} WHERE CONCAT(`FirstName`, `LastName`, `Address`, `Age`, `Birth`, `No`) like '%" + No + "%'";

                    dataTable.Clear();
                    var command = new MySqlCommand(Query, conn);
                    var adapter = new MySqlDataAdapter(command);

                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;

                    dataGridView.Columns["FirstName"].Visible = false;
                    dataGridView.Columns["LastName"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message);
                }
            }
        }

        //Data저장
        public void InsertDB(int No,string Name, DateTime Birth,int Age, string Address, string Description, string FirstName,string LastName)
        {
            using (MySqlConnection conn = new MySqlConnection(ServerInfo))
            {
                string Query = $"Insert into {_tableName} (No,Name,Birth,Age,Address,Description,FirstName,LastName) " +
                    $"values (@No, @Name, @Birth, @Age, @Address, @Description, @FirstName, @LastName)";
                try                                
                {
                    conn.Open();

                    var cmd = new MySqlCommand(Query, conn);  

                    cmd.Parameters.AddWithValue("@No", No);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Birth", Birth);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    MessageBox.Show("Data Inserted");

                    GetDataDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("fail insert \r\n" + ex.ToString());
                }
            }
        }

        //삭제
        public void DeleteDB()
        { 
            using (MySqlConnection conn = new MySqlConnection(ServerInfo))
            {
                string DeleteNo = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string Query = $"delete from {_database}.{_tableName} where no = '" + DeleteNo + "' ;";

                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataReader myReader;

                try
                {
                    conn.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Deleted No : "+DeleteNo);

                    while (myReader.Read()) { }
                    GetDataDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //기존 데이터 수정
        public void UpdateDB(int No, string Name, DateTime Birth, int Age, string Address, string Description, string FirstName, string LastName, int where)
        {
            using(MySqlConnection conn = new MySqlConnection(ServerInfo))
            { 
                try
                {
                    conn.Open();

                    string Query = $"update {_database}.{_tableName} set No = @No, Name = @Name, Birth = @Birth, Age = @Age, " +
                      $"Address = @Address, Description = @Description, FirstName = @FirstName, LastName = @LastName where No = @where";

                    var cmd = new MySqlCommand(Query, conn);
                    cmd.Parameters.AddWithValue("@No", No);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Birth", Birth.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@where", where);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (myReader.Read())
                    {
                    }
                    GetDataDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
