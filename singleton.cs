using System;
namespace Singleton	{  
	sealed class SingletonClass {  
		private static SingletonClass inst = null; 
		static int cnt = 0;
        private SingletonClass() {  
			cnt++;
			Console.WriteLine("No.of instances = "+cnt);
        }  
        public static SingletonClass Instance {  
            get {  
                if (inst == null) {  
                    inst = new SingletonClass();  
                }  
                return inst;  
            }  
        } 
		public void print(){
			Console.WriteLine("Hello World");
		}
	}
    public class Example {
		public static void Main(string[] args) {
			SingletonClass obj1 = SingletonClass.Instance;
			obj1.print();
			SingletonClass obj2 = SingletonClass.Instance;
			obj2.print();
		}
    }  
}  
