public class Main {
    public static void main(String[] args) {
                ListaEnLazada lista=new ListaEnLazada();
                Scanner leer = new Scanner (System.in);
                System.out.println("Ingresa el numero de la opción deseada.");
                System.out.println("1-insertar Cabeza");
                System.out.println("2-insertar Cola");
                System.out.println("3-Borrar");
                System.out.println("4-Imprimir");
                int numero  = leer.nextInt();
                
                //Añadir inicio
                if(numero==1){
                    System.out.println("Qué numero deseas ingresar?");
                    int cabeza = leer.nextInt();
                    lista.añadirInicio(cabeza);
                    }else{//añadirfinal
                        if(numero==2){
                            System.out.println("Qué numero deseas ingresar?");
                            int cola = leer.nextInt();
                            lista.AñadirFinal(cola);
                        }else{
                            //borrar
                        if(numero==3){
                            System.out.println("Qué numero deseas borrar?");
                            int borrarv = leer.nextInt();
                            lista.borrarValor(borrarv);
                        }else{
                            if(numero==4){
                            System.out.println("Lista:");
                            lista.mostrar();
                        }else{
                            System.out.println("Ingresa una opción válida. Intenta de nuevo");
                        }
                        }
                        }
                    }
                }
                

        class nodo{
            int valor;
            nodo siguiente;

            nodo(int valor){
                this.valor=valor;

            }
        }
        class ListaEnLazada{
            nodo cabeza;

            public void AñadirFinal(int valor){
                if(vacia()==true) {
                    cabeza=new nodo (valor);
                }
                nodo mensajero=cabeza;
                while(mensajero.siguiente!=null) {
                    mensajero=mensajero.siguiente;
                }
                mensajero.siguiente=new nodo(valor); 
            }
            public void añadirInicio(int valor) {
                if(vacia()){
                    cabeza=new nodo(valor);
                }
                nodo nuevo=new nodo(valor);
                nuevo.siguiente=cabeza;
                cabeza=nuevo;
            }
            public void borrarValor(int valor){
             
                if(vacia()){System.out.print("Lista vacia");} 

               
                if(cabeza.valor==valor){
                    cabeza=cabeza.siguiente;
                }

                
                nodo mensajero=cabeza;
                while(mensajero.siguiente!=null) {
                    if (mensajero.siguiente.valor==valor) {
                        mensajero.siguiente=mensajero.siguiente.siguiente;
                    }
                    mensajero=mensajero.siguiente;

                }
            }

            public void mostrar() {
                
                if (vacia()){
                    System.out.print("Lista vacia");
                }
                nodo mensajero=cabeza;
                while(mensajero!=null){
                    System.out.print("\n"+mensajero.valor);
                    mensajero=mensajero.siguiente;
                }
            }
            private boolean vacia() { 
                if(cabeza==null){
                    return true;
                }
                else{
                    return false;
                }
            }
        }