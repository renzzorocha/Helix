<h1 align="center">🪼 Helix</h1>

<p align="center">
<img src="https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
<img src="https://img.shields.io/badge/C%23-10-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
<img src="https://img.shields.io/badge/License-MIT-success?style=for-the-badge" />
<img src="https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow?style=for-the-badge" />
</p>

## 📖 Visão Geral
- **Helix** é uma biblioteca em **C# / .NET 9** criada para estudar e catalogar algoritmos e estruturas de dados. <br> 
- O repositório funciona como um _playground_ educacional: cada implementação vem acompanhada de exemplos de uso e documentação em Markdown para facilitar o aprendizado contínuo. <br> 

---

## 📂 Estrutura de Pastas

```text
Helix
├── src                           # Código-fonte
│   ├── Helix.Core                # Biblioteca de classes
│   │   ├── Properties            # Propriedades do Projeto
│   │   └── Helix.Core.csproj
│   │
│   └── Helix.Playground          # Projeto console para testes
│       ├── Helix.Playground.csproj
│       └── Program.cs            
├── .gitattributes                # Diz ao Git como tratar cada arquivo do repositório (EOL, texto/binário, diff/merge, filtros, exportação).                       
├── Helix.sln                     # Solução principal
├── LICENSE.txt                   # MIT License
├── README.md                     # Documentação em Markdown
```
---

## 🚀 Tecnologias
- **C# 10**
- **.NET 9 SDK**
- **Markdown** para Documentação

---

## ▶️ Como Executar

```bash
# 1. Clone o repositório
git clone https://github.com/<seu-usuario>/helix.git
cd helix

# 2. Restaure as dependências
dotnet restore

# 3. Execute o playground
dotnet run --project src/Helix.Playground
```

---

## ⚙️ Contribuindo
1. Faça um **fork** do projeto.  
2. Crie uma branch:  
```bash
git checkout -b feature/minha-feature
```
3. Commit suas alterações:
```bash
git commit -m "feat: minha feature" (follow the semantic commit pattern please) 
```
4. Envie para o seu repositório:
```bash
git push origin feature/minha-feature
```
5. Abra um Pull Request.

---

## 📜 Licença
Distribuído sob a licença MIT. Consulte o arquivo LICENSE.txt para mais informações.
