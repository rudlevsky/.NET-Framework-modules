<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
numbers.TakeWhile(
		(n, index) => n >= index).Dump("First numbers not less than their position:"); 