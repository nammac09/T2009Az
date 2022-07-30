package com.example.thidmn.Repo;

import com.example.thidmn.Entity.UserEntity;
import org.hibernate.metamodel.model.convert.spi.JpaAttributeConverter;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface UserRepo extends JpaRepository<UserEntity,Integer> {
    List<UserEntity> findUserEntityByName(String name);
    UserEntity deleteUserEntityById(int id);
    UserEntity findUserEntityById(int id);
}
