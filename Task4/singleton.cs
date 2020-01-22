using System;
namespace Singleton	{  
	sealed class SingletonClass {  
		private static SingletonClass inst = null; 
		static int cnt = 0;
        private SingletonClass() {  
			cnt++;
			Console.WriteLine("No.of instances = "+cnt);
        }  
        public static SingletonClass getInstance() {    
        	if (inst == null) {  
            	inst = new SingletonClass();  
            }  
            return inst;    
        } 
		public void print(){
			Console.WriteLine("Hello World");
		}
	}
    public class Example {
		public static void Main(string[] args) {
			SingletonClass obj1 = SingletonClass.getInstance();
			obj1.print();
			SingletonClass obj2 = SingletonClass.getInstance();
			obj2.print();
		}
    }  
}  
