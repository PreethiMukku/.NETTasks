class Student{
    String collegeName = "ABC..";
    
    public void display(){
        System.out.println("Parent class\n");
    } 
}
class MpcStudent extends Student{
    
    String name;
    MpcStudent(String name){
        this.name = name;
    }
    public void show(){
        System.out.println("Child class\n");
        System.out.println("Name = "+name+"\n"+"Branch = MPC ");
    }
}
public class Test{
    public static void main(String []args){
        MpcStudent m = new MpcStudent("Shobha");
        m.display();
        m.show();
        System.out.println("Collegename = "+m.collegeName+"\n");
        
    }
}