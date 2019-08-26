using System;
class MyClass {
	static void Main(string[] args) 
	{
		try{
			int count = Convert.ToInt32(Console.ReadLine());
			if(count<=0){
				System.Console.WriteLine("INVALID INPUT");				
			}
			else{
					string star ="";
					for(int i=0; i <= count; i++){
						star += "*";
					}
					System.Console.WriteLine(star);
					System.Console.WriteLine(" * ");
					System.Console.WriteLine(star);
					
			}
			
		}
		catch(Exception ex){
			System.Console.WriteLine("INVALID INPUT");
		}
		
		
	}
}
