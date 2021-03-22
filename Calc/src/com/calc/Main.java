package com.calc;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	double firstNumber;
	double secondNumber;
	//boolean isCountinue = true;
	String operation;
	double result;
	Scanner in = new Scanner(System.in);


		System.out.println("Введите первое число ");
		firstNumber = in.nextDouble();

		System.out.println("Введите нужное действие: (* , / ,- ,+)");
		operation = in.nextLine();
		System.out.println("Введите второе число ");
		secondNumber = in.nextDouble();
		switch (operation) {
			case "*": {
				result = firstNumber * secondNumber;
				System.out.println("Результат умножения :" + result);
				break;
			}
			case "/": {
				if (firstNumber == 0 || secondNumber == 0){
					System.out.println("на ноль делить нельзя!");
				}
				else {
					result = firstNumber / secondNumber;
					System.out.println("Результат деления :" + result);
				}
				break;
			}
			case "-": {
				result = firstNumber - secondNumber;
				System.out.println("Результат вычитания :" + result);
				break;
			}
			case "+": {
				result = firstNumber + secondNumber;
				System.out.println("Результат сложения :" + result);
				break;
			}

		}


	}
}
