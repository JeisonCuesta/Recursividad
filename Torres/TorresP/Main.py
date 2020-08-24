def hanoi (num, inicio='1', temporal='2', fin='3'):
    if num==1:
        print('Se mueve el disco de la torre (' + inicio + ') a la torre (' + fin +')')
    else:   
        hanoi(num-1, temporal,inicio, fin)
        print('Se mueve el disco de la torre (' + inicio + ') a la torre (' + fin +')') 
        hanoi(num-1,inicio, fin, temporal)

discos=int(input('INGRESE EL NUMERO DE DISCOS DE LAS TORRES HANOI...'))
hanoi(discos)




