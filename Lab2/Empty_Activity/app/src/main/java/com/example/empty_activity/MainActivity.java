package com.example.empty_activity;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

//@RequiresApi(api = Build.VERSION_CODES.LOLLIPOP)
public class MainActivity extends AppCompatActivity {
    private TextView tv_l1;
    private TextView tv_l2;
    private Button btn_go;
    private Phraser Phr = new Phraser();//Подключение класса
    String str = Phr.PhraserGen();
    String str1 = "Всё, что нам нужно - это "+ str +"."; //формирование строки, PhraserGen возвращает строки из класса
    String str2 = bigS(str)+" - это всё, что нам нужно.";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tv_l1 = findViewById(R.id.tv_l1); //Присоединение к переменным
        tv_l2 = findViewById(R.id.tv_l2);
        btn_go = findViewById(R.id.btn_go);
        tv_l1.setText(str1);//Установить значение в TextView
        tv_l2.setText(str2);
        View.OnClickListener clickbtn = new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                str = Phr.PhraserGen();
                str1 = "Всё, что нам нужно - это "+ str +".";
                str2 = bigS(str)+" - это всё, что нам нужно.";
                tv_l1.setText(str1);
                tv_l2.setText(str2);
            } //Создание события на кнопку
        };
        btn_go.setOnClickListener(clickbtn);
    }

    private  String bigS(String str){
        return str.substring(0,1).toUpperCase() + str.substring(1); //Разбивает строку над подстроку. 1 подстрока заглавная буква, 2 продолжение текста
    }

}

