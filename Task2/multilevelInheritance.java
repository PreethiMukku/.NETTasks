class Student{
    
    String collegeName = "ABC..";
    
    public void display(){
        System.out.println("Iam a student\n");
    } 
}
class MpcStudent extends Student{
    
    String name;
    
    MpcStudent(String name){
        this.name = name;
    }
    public void show(){
        System.out.println("Name = "+name+"\n"+"Branch = MPC ");
    }
}
class JeeMains extends MpcStudent{
    
    JeeMains(String name){
        super(name);
    }
    
    public void details(){
        System.out.println("Coaching = JEE Mains\n");
    }
}
public class Test{
    
    public static void main(String []args){
        JeeMains obj = new JeeMains("Shobha");
        obj.display();
        obj.show();
        obj.details();
        System.out.println("Collegename = "+obj.collegeName);
        
    }
}