package com.example.prj1;

import androidx.room.ColumnInfo;
import androidx.room.Entity;
import androidx.room.PrimaryKey;

@Entity(tableName = "User")
public class User {
    @PrimaryKey(autoGenerate=true)
    public int id;
    @ColumnInfo(name="name")
    public String name;
    @ColumnInfo(name="gender")
    public String gender;
    @ColumnInfo(name="description")
    public String description;
    @ColumnInfo(name="email")
    public String email;
}
