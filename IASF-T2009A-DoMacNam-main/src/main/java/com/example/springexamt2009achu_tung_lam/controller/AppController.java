package com.example.springexamt2009achu_tung_lam.controller;

import com.example.springexamt2009achu_tung_lam.entity.EmployeeEntity;
import com.example.springexamt2009achu_tung_lam.service.EmployeeService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import java.util.List;

@Controller
public class AppController {
    @Autowired
    private EmployeeService service;

    @RequestMapping("/")
    public String viewHomePage(Model model) {
        List<EmployeeEntity> listEmployees = service.listAll();
        model.addAttribute("listEmployees", listEmployees);
        return "index";
    }

    @RequestMapping("/new")
    public String showNewPage(Model model) {
        EmployeeEntity employee = new EmployeeEntity();
        model.addAttribute("employee", employee);

        return "new_product";
    }

    @RequestMapping(value = "/save", method = RequestMethod.POST)
    public String saveEmployee(@ModelAttribute("employee") EmployeeEntity employee) {
        service.save(employee);

        return "redirect:/";
    }


}
