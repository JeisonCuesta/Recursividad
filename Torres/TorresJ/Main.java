import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        
        Scanner leer = new Scanner(System.in);
        hanoi ha = new hanoi();
        
        int discos = 0;
        System.out.println("INGRESE EL NUMERO DE DISCOS DE LAS TORRES HANOI...");
        discos = leer.nextInt();
        ha.hanoi(discos, 1, 2, 3);  
        System.out.println("\n FIN DEL JUEGO");
    } 
}

class hanoi{
    public void hanoi(int num, int inicio,  int temporal,int fin){
        if (num ==1) {
            System.out.println("Se mueve el disco de la torre (" + inicio + ") a la torre (" + fin +")");
        }else{
           hanoi(num-1,inicio,fin,temporal);
            System.out.println("Se mueve el disco de la torre (" + inicio + ") a la torre (" + fin +")");
            hanoi(num-1,temporal,inicio,fin);
        }
    }   
}


