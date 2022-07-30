package com.example.thidmn.Service;

import com.example.thidmn.Entity.UserEntity;
import com.example.thidmn.Repo.UserRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class UserService {
    @Autowired
    UserRepo userRepo;

    public List<UserEntity> getAll(){
        return userRepo.findAll();
    }
    public UserEntity getUser(int id){
        return userRepo.findUserEntityById(id);
    }
    public UserEntity deleteUser(int id){
        return userRepo.deleteUserEntityById(id);
    }

    public String create(UserEntity user,Boolean update){
        if(findByName(user.getName()) != null && !update){
            return "Ton Tai: " + user.getName();
        }
        userRepo.save(user);
        return "thanh cong";
    }
    public List<UserEntity> findByName(String name){
        return userRepo.findUserEntityByName(name);
    }
}
