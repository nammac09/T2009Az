package com.example.springexamt2009achu_tung_lam.repository;

import com.example.springexamt2009achu_tung_lam.entity.EmployeeEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface EmployeeRepository extends JpaRepository<EmployeeEntity, Long> {}
