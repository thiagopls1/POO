using Aula_4___Ex_1;

Usuario jadson = new Usuario("Jadson", "111.111.111-11");
BilheteUnico b1jadson = new BilheteUnico("estudante", jadson);

CentralRecarga picPay = new CentralRecarga("picPay");

picPay.Recarregar(b1jadson, 10.0f, "estudante");
picPay.Recarregar(b1jadson, 5.0f, "comum");