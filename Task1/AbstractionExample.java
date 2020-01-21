abstract class Person{
    String name;
    String gender;
    Person(String name, String gender){
        this.name = name;
        this.gender = gender;
    }
    abstract void displayDetails(); 
}
class Student extends Person{
    int rollno;
    Student(String name, String gender, int rollno){
        super(name,gender);
        this.rollno = rollno;
    }
    public void displayDetails(){
        System.out.println("Iam a student");
        System.out.println("Name = "+name+"\nRollno = "+rollno+"\n");
    }
    
}
class Employee extends Person{
    String empId;
    Employee(String name, String gender, String empId){
        super(name,gender);
        this.empId = empId;
    }
    public void displayDetails(){
        System.out.println("Iam an Employee");
        System.out.println("Name = "+name+"\nId = "+empId);
    }
    
}
public class Testclass{

     public static void main(String []args){
        Person p;
        p = new Student("Sheetal","Female",1232);
        p.displayDetails();
        p = new Employee("Priya","Female","B01A12");
        p.displayDetails();
     }
}