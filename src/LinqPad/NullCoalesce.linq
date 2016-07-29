<Query Kind="Program" />

void Main()
{
	var someClass = new SomeClass();
	var result = someClass?.SomeString?.ToUpper();
	
}

class SomeClass{
	public string SomeString {get;set;}
}

// Define other methods and classes here
