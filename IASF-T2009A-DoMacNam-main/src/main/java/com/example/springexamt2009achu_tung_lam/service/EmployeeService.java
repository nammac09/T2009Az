package com.example.springexamt2009achu_tung_lam.service;

import com.example.springexamt2009achu_tung_lam.entity.EmployeeEntity;
import com.example.springexamt2009achu_tung_lam.repository.EmployeeRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;


@Service
@Transactional
public class EmployeeService {

    @Autowired
    private EmployeeRepository employeeRepository;

    public List<EmployeeEntity> listAll() {
        return employeeRepository.findAll();
    }

    public void save(EmployeeEntity employee) {
        employeeRepository.save(employee);
    }

}
