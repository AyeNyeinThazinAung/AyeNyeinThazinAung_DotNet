﻿// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using System.Data;
using DotNetTrainingBatch3.ConsoleApp.AdoDotNetExamples;
using DotNetTrainingBatch3.ConsoleApp.DapperExamples;
using DotNetTrainingBatch3.ConsoleApp.EFCoreExamples;

Console.WriteLine("Hello, World!");

//F5=> Run

//Ctrl + K, C=> Disable
//Ctrl + k, C=> Enable

//Console.ReadLine();

//Ctrl + .

//F9 => Break point
//Shift + F5 => Stop

//UI, BL, DA =>SQL
//CRUD

//ntier three tier

//Kpay
//Transfer
//from mobile no
//to mobile no
//amount
//passcode

//mobile no (-1000)
//mobile no (+1000)
//from to +1000 date

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
//sqlConnectionStringBuilder.DataSource = ".";
//sqlConnectionStringBuilder.InitialCatalog = "TestDb";
//sqlConnectionStringBuilder.UserID = "sa";
//sqlConnectionStringBuilder.Password = "sa@123";

//SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
//Console.WriteLine("Connection Opening...");
//connection.Open();
//Console.WriteLine("Connection Opened...");

////DataSet
////DataTable
////DataRow
////DataColumn

//string query = @"SELECT [BlogId]
//      ,[BlogTitle]
//      ,[BlogAuthor]
//      ,[BlogContent]
//  FROM [dbo].[Tbl_Blog]";


//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);

//Console.WriteLine("Connection closing...");
//connection.Close();
//Console.WriteLine("Connection closed...");   

//foreach (DataRow dr in dt.Rows)
//{

//    Console.WriteLine("Title..." + dr["BlogTitle"]);
//    Console.WriteLine("Author..." + dr["BlogAuthor"]);
//    Console.WriteLine("Content..." + dr["BlogContent"]);
//}

AdoDotNetExample adoDotNetExample= new AdoDotNetExample();
////adoDotNetExample.Read();
////adoDotNetExample.Edit(1);
////adoDotNetExample.Edit(11);
//adoDotNetExample.("test title", "test author", "test content" );
//adoDotNetExample.Update(1002, "test title 2", "test author 2", "test content 2" );
//adoDotNetExample.Delete(1002);

//DapperExample dapperExample = new DapperExample();
//dapperExample.Read();

//dapperExample.Edit(1);
//dapperExample.Edit(11);

//dapperExample.Create("test title", "test author", "test content" );
//dapperExample.Update(2002, "test title 2", "test author 2", "test content 2" );
//dapperExample.Delete(2002);

EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Read();
//eFCoreExample.Edit(1);
//eFCoreExample.Edit(11);

//eFCoreExample.Create("test title", "test author", "test content" );
//eFCoreExample.Update(3002, "test title 2", "test author 2", "test content 2" );
eFCoreExample.Delete(3002);



//hello

Console.ReadKey();


