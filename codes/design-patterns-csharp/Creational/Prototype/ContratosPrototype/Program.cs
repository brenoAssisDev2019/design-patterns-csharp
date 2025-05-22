// Criando modelos base (prototypes)
using ContratosPrototype.Models;

var serviceModel = new ServiceAgreement("Modelo");
var ndaModel = new NdaAgreement("Modelo");
var partnerModel = new PartnershipAgreement("Modelo");

// Clonando para clientes
var contrato1 = (ServiceAgreement)serviceModel.Clone();
contrato1.ClientName = "ACME Corp";

var contrato2 = (NdaAgreement)ndaModel.Clone();
contrato2.ClientName = "John Doe";

var contrato3 = (PartnershipAgreement)partnerModel.Clone();
contrato3.ClientName = "Startup XYZ";

// Imprimindo
contrato1.Print();
contrato2.Print();
contrato3.Print();