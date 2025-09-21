def ejer1():
    precio = int(input("Ingrese el precio del producto: "))
    codigo = int(input("Ingrese el código de descuento (1=estudiante, 2=empleado, 3=cliente frecuente): "))

    if codigo == 1:
        descuento = 0.10
    elif codigo == 2:
        descuento = 0.15
    elif codigo == 3:
        descuento = 0.20
    else:
        descuento = 0
        print("Código inválido. No se aplicará descuento.")

    precio_final = precio * (1 - descuento)

    if precio > 500:
        precio_final *= 0.95  # 5% adicional

    print("Precio final:", round(precio_final, 2))

import math
 
def ejer2():
    print("EJERCICIO 2: Evaluación de nota")
    nota = int(input("Ingrese la nota (0 a 20): "))

    
    if nota < 0 or nota > 20:
        print("Nota fuera de rango. Ingrese un valor entre 0 y 20.")
    else:
        
        if nota <= 10:
            print("Desaprobado")
        elif nota <= 13:
            print("Regular")
        elif nota <= 17:
            print("Bueno")
        else:
            print("Excelente")

        
        if nota >= 14 and nota % 2 == 0:
            print("Buen desempeño con nota par")

        if nota % 2 != 0 or nota < 11:
            print("Necesita reforzar")

        
        raiz = math.sqrt(nota)
        cubo = nota ** 3

        print("Raíz cuadrada:", round(raiz, 1))
        print("Potencia al cubo:", cubo)





