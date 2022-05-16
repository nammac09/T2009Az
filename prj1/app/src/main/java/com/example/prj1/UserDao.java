package com.example.prj1;

import static androidx.room.OnConflictStrategy.REPLACE;

import androidx.room.Dao;
import androidx.room.Insert;
import androidx.room.Query;

import java.util.List;

@Dao
public interface UserDao {
    @Insert(onConflict = REPLACE)
    void insertUser(User user);

    @Query("SELECT*FROM User")
    List<User> getAllUser();


}