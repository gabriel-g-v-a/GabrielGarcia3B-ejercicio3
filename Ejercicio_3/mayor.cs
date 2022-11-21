class mayor{
    public int num1;
    public int num2;
    public int num3;
    public void NumeroMayor(){
        Console.WriteLine("Ingrese el primero número");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer número");
        num3=Convert.ToInt32(Console.ReadLine());

        if(num1>num2 && num1>num3){
            Console.WriteLine("El número mayor es: "+num1);
        }else if(num2>num1 && num2>num3){
            Console.WriteLine("El número mayor es: "+num2);
        }else if (num3>num1 && num3>num2){
            Console.WriteLine("El número mayor es: "+num3);
        }
    }
}