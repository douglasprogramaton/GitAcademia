




    double num1, num2, resultado;
    int op;
    Console.WriteLine("Digite dois numero: ");
    num1 = double.Parse(Console.ReadLine());
    num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("\n Escolha a operação: \n1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão\n5.Potência\n\n Escolha :");
    op = int.Parse(Console.ReadLine());
    if (op == 1)
    {
        resultado = num1 + num2;
        Console.WriteLine("Soma = " + resultado);

    } else if (op == 2)
    {
        resultado = num1 - num2;
        Console.WriteLine("Subtração = " + resultado);
    }

    else if (op == 3)
    {
        resultado=num1 * num2;
        Console.WriteLine("Multiplição= "+ resultado);

    }else if(op == 4)
    {
        resultado= num1 / num2;
        Console.WriteLine("Divisão= "+resultado);

    }else if (op == 5)
    {
        resultado = Math.Pow(num1, num2);
        Console.WriteLine("Potência = " + resultado);

    }


