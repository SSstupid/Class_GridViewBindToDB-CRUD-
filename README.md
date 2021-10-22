# Class_GridViewBindToDB(CRUD)
 Class_CRUD

## ClaseName => GridWithDB

* Columns : No, Name, Birth, Age, Address, Description, FirstName, LastName
Ex)
```
 public partial class Form1 : Form
 {  GridWithDB GWD = new GridWithDB("localhost", "3306", "test", "root", "1234"); } // Server detail set
OR  GridWithDB GWD = new GridWithDB(); //Default Value => "localhost", "3306", "test", "root", "1234"

 private void Form1_Load(object sender, EventArgs e)
  {
      GWD.SetGridTable(dataGridView1, "cuslist");  //Set GridView to bind, table name
      GWD.GetDataDB();  //Bind start
      dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
  }
```

### Create
```
GWD.InsertDB(NoNumber(PrimaryKey), Name, BirthDay, CusAge, Address.Text, Description.Text, FirstName.Text, LastName.Text)
```

### Read
```
GWD.GetDataDB();
```

### Update
```
GWD.UpdateDB(NoNumber(PrimaryKey)_you_choose, Name, BirthDay, CusAge, Address.Text, Description.Text, FirstName.Text, LastName.Text, Where to Update PrimaryKey.));

Ex) GWD.UpdateDB(Convert.ToInt32(textBox1.Text), Name1, BirthDay, CusAge, Address.Text, Description.Text, FirstName.Text, LastName.Text, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
```

### Delete
```
GWD.DeleteDB();
```

### Search
```
GWD.GetDataDB(string Serch_Keyword);
```

### Img
<img src=https://user-images.githubusercontent.com/90036120/138431294-30a94cd4-6a03-4afb-be3c-328cbd915230.JPG width="900" height="450"/>.
*****************
<img src=https://user-images.githubusercontent.com/90036120/138433307-77820009-bf95-4c38-ab03-c8702c23831e.JPG width="700" height="330"/>.


************************************************************************************

FirstName, LastName, Name을 추후 검색할 때 유용할 것 같아서 각각 추가했습니다.    
제 생각과는 별개로 like를 이용해서 간단하게 검색을 할 수 있더군요.     
나중에 손을 조금 볼 필요가 잇어보이네요. Name, (Last,FirstName) 둘 중 하나만 있어도 충분한 상황이라;;;     
    
처음으로 DataGridView와 DB를 사용해봤습니다.     
아무것도 모르는 상태라;;; 애도 먹고 많은 실수, 시간이 들어갔네요. ㅠㅠ     
그덕에 감은 조금 잡은 느낌입니다.     
     
크롤링, Https는 Request Header에 원하는 데이터를 보내게되는데요.     
DB도 비슷한맥락인것 같습니다.     
DB에 연걸하고 원하는 행동을 할 Query문을 보내면 되는 방식이네요.     
기본에 대한 이해가 없는 상태라 CRUD에 한참이 걸렸습니다.    
     
자료찾는데도 애를 먹었습니다. SQL CRUD라고 검색하면 자료가 많더군요    
유튜브에 DataGridView binding하는 한국어 자료가 없어서,    
영상을 찍으면 좋겠다는 생각이 들었습니다. 
