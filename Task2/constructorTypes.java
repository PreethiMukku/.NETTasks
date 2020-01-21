class Test1{
    Test1(){} //Default-cnstructor
}

class Test2{
    
    Test2(){
        System.out.println("No-args constructor\n"); 
    }
}

class Student{

    String collegeName;
    String name;
    int rollno;

    Student(String collegeName,String name,int rollno){ // Parametric constructor

        this.collegeName = collegeName;
        this.name = name;
        this.rollno = rollno;

    }

    public void display(){

        System.out.println(name+" "+rollno+" "+collegeName+"\n");

    }
}
  
public class HelloWorld{

    public static void main(String []args){
    
        Test1 t1 = new Test1();
        Test2 t2 = new Test2();
        System.out.println("Object of default constructor = "+t1+"\n");
        
        Student obj1 = new Student("ABC..","Neeta",101);
        obj1.display();

    }

}