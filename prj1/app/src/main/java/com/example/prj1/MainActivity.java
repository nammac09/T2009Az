package com.example.prj1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import java.util.List;

public class MainActivity extends AppCompatActivity {
    Spinner spinner;
    EditText edUser,edGmail,edDes;
    CheckBox ck;
    Button btSend;
    AppDatabase db;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        initView();
        listehEvent();
    }

    private void listehEvent() {
        btSend.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (edUser.getText().toString().isEmpty()){
                    Toast.makeText(MainActivity.this, "Please enter username", Toast.LENGTH_LONG).show();
                    return;
                }
                if (edGmail.getText().toString().isEmpty()){
                    Toast.makeText(MainActivity.this, "Please enter email", Toast.LENGTH_LONG).show();
                    return;
                }
                if (edDes.getText().toString().isEmpty()){
                    Toast.makeText(MainActivity.this, "Please enter desciption", Toast.LENGTH_LONG).show();
                    return;
                }
                if (!ck.isChecked ()){
                    Toast.makeText(MainActivity.this,"Please agree rules", Toast.LENGTH_LONG).show();
                    return;
                }
                User user = new User();
                user.name = edUser.getText().toString();
                user.email = edGmail.getText().toString();
                user.gender = spinner.getSelectedItem().toString();

                user.description = edDes.getText().toString();
                db.UserDao().insertUser(user);
                List<User> list = db.UserDao().getAllUser();
                Toast.makeText(MainActivity.this,"Have " + list.size() + " custom feedback", Toast.LENGTH_LONG).show();

            }
        });
    }

    private void initView() {
        String[] genders = {"MALE", "FEMALE", "Other"};
        spinner  = (Spinner) findViewById(R.id.spinner);
        edUser = (EditText) findViewById(R.id.edUser);
        edDes = (EditText) findViewById(R.id.edDes);
        edGmail = (EditText) findViewById(R.id.edGmail);
        ck = (CheckBox) findViewById(R.id.ck);
        db = AppDatabase.getAppDatabase(this);
        btSend = (Button) findViewById(R.id.btSend);
        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_dropdown_item,genders);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinner.setAdapter(adapter);

    }
}