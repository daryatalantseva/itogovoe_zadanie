﻿/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. */

string[] array_str = new string[15] {"Vasya", "6987", "diplomat", "мир", "100", "мир", "15", "xo-xo", "007", "dog", "cap", "Задача", "0190283", "Summer", "ITOG"};
string[] array2 = new string[array_str.Length];
int count = 0;
for (int i = 0; i < array_str.Length; i++)
    {
    if(array_str[i].Length <= 3)
        {
        array2[count] = array_str[i];
        count++;
        }
    }
