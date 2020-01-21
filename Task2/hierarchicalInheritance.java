class Student{

    String collegeName = "ABC..";
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
class BipcStudent extends Student{
    
    String name;
    
    BipcStudent(String name){
        this.name = name;
    }
    public void print(){
        System.out.println("Name = "+name+"\n"+"Branch = BIPC ");
    }
}
public class Test{
    
    public static void main(String []args){
        MpcStudent obj1 = new MpcStudent("Neeta");
        BipcStudent obj2 = new BipcStudent("Shobha");
        
        obj1.show();
        System.out.println("College Name = "+obj1.collegeName+"\n");
        obj2.print();
        System.out.println("College Name = "+obj2.collegeName+"\n");
        
    }
}