class Test {
  
  protected Test(int n) {
    System.out.println("i'm born int! "+n);
  }
  public Test(String str) {
    System.out.println("i'm born double!");
  }
}
public class Main {
    public static void main(String[] args) {
  
      Test t1 = new Test(3); 
      Test t2 = new Test("Hello world");
    }
}