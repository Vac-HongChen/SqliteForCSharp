﻿using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\001\Desktop\skypath.db";
                //连接数据库
                SQLiteHelper.ConnectDataBase(path);
                //删除一个表
                //SQLiteHelper.DeleteTable("ss");
                //创建一个表
                //SQLiteHelper.CreateTable("user", new string[] { "id", "name" ,"acc","pwd"});
                //添加数据
                //SQLiteHelper.AddData("user", new string[] { "54", "xname", "acc", "pwd" });
                //SQLiteHelper.AddData("user", new string[] { "33", "xname", "acc", "pwd" });
                //删除数据
                //SQLiteHelper.DeleteData("user", new string[] { "id" }, new string[] { "=" }, new string[] { "1" });
                //查询数据
                //SQLiteHelper.ReadTable("user");
                //foreach (var item in list)
                //{
                //    //Console.WriteLine(item[1]);
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
