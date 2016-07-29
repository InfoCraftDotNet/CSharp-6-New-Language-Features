<Query Kind="Statements" />

// OLD
new Dictionary<int, string>
                {
                    {1, "String 1"},
                    {2, "String A"},
                    {3, "String Foo"}
                }.Dump();

// NEW				
new Dictionary<int, string>
                {
                    [1] = "String 1",
                    [2] = "String A", 
                    [3] = "String Foo"
                }.Dump();				

// NEW overwrite
new Dictionary<int, string>
                {
                    [1] = "String 1",
                    [1] = "String A", 
                    [2] = "String Foo"
                }.Dump();	
				
// OLD overwrite
new Dictionary<int, string>
                {
                    {1, "String 1"},
                    {1, "String A"},
                    {2, "String Foo"}
                }.Dump();				