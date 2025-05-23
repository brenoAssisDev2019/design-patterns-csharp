// See https://aka.ms/new-console-template for more information
// Funcionários comuns
using CompositePattern.Company;

var dev1 = new Employee("Ana", "Desenvolvedora Frontend", 8000);
var dev2 = new Employee("Carlos", "Desenvolvedor Backend", 8500);
var qa1 = new Employee("Fernanda", "Analista de QA", 7500);
var design1 = new Employee("Tiago", "Designer UI/UX", 7000);

// Gerente de Tecnologia
var techLead = new Manager("Roberta", "Tech Lead", 12000);
techLead.AddSubordinate(dev1);
techLead.AddSubordinate(dev2);

// Gerente de Produto
var productLead = new Manager("Júlio", "Product Manager", 11500);
productLead.AddSubordinate(design1);
productLead.AddSubordinate(qa1);

// Diretor de Tecnologia
var cto = new Manager("Renato", "CTO", 18000);
cto.AddSubordinate(techLead);
cto.AddSubordinate(productLead);

// CEO
var ceo = new Manager("Patrícia", "CEO", 25000);
ceo.AddSubordinate(cto);

// Exibir hierarquia
ceo.DisplayHierarchy();
