package com.example.thidmn.Controller;

import com.example.thidmn.Entity.UserEntity;
import com.example.thidmn.Service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.List;

@Controller
public class WebController {
    @Autowired
    UserService userService;

    @GetMapping({"/","/index"})
    public String list(Model model,String msg){
        List<UserEntity> list = userService.getAll();
        model.addAttribute("list",list);

        UserEntity user = new UserEntity();
        model.addAttribute("user",user);
        if(msg != null) model.addAttribute("msg",msg);
        return "index";
    }

    @GetMapping(value ="/edit/${id}")
    public String edit(@PathVariable("id")int id,Model model ){
        model.addAttribute("edit",true);
        UserEntity user = userService.getUser(id);
        model.addAttribute("user",user);

        List<UserEntity> list = userService.getAll();
        model.addAttribute("list",list);
        return "index";
    }

    @PostMapping(value ="/create")
    public String create(UserEntity user,Model model){
        if(user == null) return list(model,"");
        String msg = userService.create(user,false);
        return list(model,msg);
    }

    @PostMapping(value ="/update")
    public String update(UserEntity user,Model model){
        String msg = userService.create(user,true);
        return list(model,msg);
    }
    @PostMapping(value ="/delete/${id}")
    public String delete(@PathVariable("id") int id,Model model){
        UserEntity user = userService.deleteUser(id);

        return list(model,"Thanh cong");
    }
}
