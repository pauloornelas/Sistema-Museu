
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Museu Multitemático - README</title>
  <style>
    body {
      font-family: 'Arial', sans-serif;
      margin: 20px;
      background: linear-gradient(to right, #f9f9f9, #f1f1f1);
      color: #333;
      line-height: 1.6;
    }
    h1, h2, h3 {
      color: #2c3e50;
      text-align: center;
    }
    h1 {
      font-size: 2.5em;
      margin-bottom: 20px;
    }
    pre {
      background: #2c3e50;
      color: #ecf0f1;
      padding: 15px;
      border-radius: 8px;
      overflow-x: auto;
      font-size: 0.9em;
    }
    code {
      background: #ecf0f1;
      color: #c0392b;
      padding: 4px 6px;
      border-radius: 4px;
      font-size: 0.9em;
    }
    .toc {
      background: #3498db;
      color: #fff;
      padding: 15px;
      border-radius: 8px;
      margin-bottom: 20px;
    }
    .toc a {
      color: #ecf0f1;
      text-decoration: none;
    }
    .toc a:hover {
      text-decoration: underline;
    }
    .section {
      margin-bottom: 30px;
    }
    .toggle-btn {
      cursor: pointer;
      background: #3498db;
      color: white;
      padding: 10px 15px;
      border: none;
      border-radius: 8px;
      margin-top: 10px;
      display: inline-block;
    }
    .toggle-content {
      display: none;
      margin-top: 10px;
    }
    ul {
      padding-left: 20px;
    }
    ul li {
      margin-bottom: 8px;
    }
    .note {
      background: #e74c3c;
      color: white;
      padding: 10px;
      border-radius: 8px;
      margin-top: 20px;
    }
    .highlight {
      background: #2ecc71;
      color: white;
      padding: 10px;
      border-radius: 8px;
    }
  </style>
</head>
<body>
  <h1>Museu Multitemático - Viagem a Marte</h1>
  <p>Este projeto é uma API desenvolvida em .NET para gerenciar exposições de um museu multitemático, focando na primeira viagem do homem a Marte. O banco de dados está hospedado na AWS RDS, enquanto a API roda localmente.</p>

  <div class="toc">
    <h2>📚 Índice</h2>
    <ul>
      <li><a href="#descricao">Descrição do Projeto</a></li>
      <li><a href="#funcionalidades">Funcionalidades Principais</a></li>
      <li><a href="#tecnologias">Tecnologias Utilizadas</a></li>
      <li><a href="#preparo-ambiente">Preparo do Ambiente</a></li>
      <li><a href="#estrutura-pastas">Estrutura de Pastas</a></li>
      <li><a href="#execucao">Execução do Projeto</a></li>
      <li><a href="#documentacao">Documentação da API</a></li>
      <li><a href="#melhorias">Possíveis Melhorias Futuras</a></li>
    </ul>
  </div>

  <div id="descricao" class="section">
    <h2>🔍 Descrição do Projeto</h2>
    <p>O objetivo deste projeto é fornecer uma API para:</p>
    <ul>
      <li>Gerenciar o catálogo de obras da exposição.</li>
      <li>Receber e processar feedbacks dos visitantes por meio de questionários.</li>
      <li>Permitir o upload de imagens diretamente associadas às obras.</li>
      <li>Gerar relatórios de satisfação baseados nos dados coletados.</li>
    </ul>
  </div>

  <div id="funcionalidades" class="section">
    <h2>🌟 Funcionalidades Principais</h2>
    <ul>
      <li>Cadastro, leitura, atualização e exclusão de obras (CRUD completo).</li>
      <li>Upload de imagens para as obras (arquivos .png e .jpeg).</li>
      <li>Gerenciamento de feedbacks com análises percentuais de satisfação.</li>
      <li>Documentação interativa da API usando Swagger.</li>
    </ul>
  </div>

  <div id="tecnologias" class="section">
    <h2>🛠️ Tecnologias Utilizadas</h2>
    <ul>
      <li><strong>.NET 8.0:</strong> Framework principal para desenvolvimento backend.</li>
      <li><strong>Entity Framework Core:</strong> ORM para interação com banco de dados.</li>
      <li><strong>PostgreSQL:</strong> Banco de dados hospedado no Amazon RDS.</li>
      <li><strong>Swagger (Swashbuckle):</strong> Documentação interativa para testar os endpoints.</li>
    </ul>
  </div>

  <div id="preparo-ambiente" class="section">
    <h2>💻 Preparo do Ambiente</h2>
    <button class="toggle-btn">Instruções para Linux</button>
    <div class="toggle-content">
      <h3>Linux</h3>
      <ol>
        <li>Instale o .NET SDK:
          <pre><code>sudo apt-get update && sudo apt-get install -y dotnet-sdk-8.0</code></pre>
        </li>
        <li>Certifique-se de que sua máquina está conectada à internet para acessar o banco de dados PostgreSQL hospedado na AWS.</li>
      </ol>
    </div>
    <button class="toggle-btn">Instruções para Windows</button>
    <div class="toggle-content">
      <h3>Windows</h3>
      <ol>
        <li>Baixe e instale o .NET SDK a partir de:
          <a href="https://dotnet.microsoft.com/download/dotnet/8.0" target="_blank">https://dotnet.microsoft.com/download/dotnet/8.0</a>
        </li>
      </ol>
    </div>
  </div>

  <div id="estrutura-pastas" class="section">
    <h2>📂 Estrutura de Pastas</h2>
    <pre>
MuseuAPI/
├── Controllers/         # Controladores da API
├── Data/                # Configuração do banco de dados
├── Dtos/                # Objetos de transferência de dados
├── Entities/            # Modelos de entidades
├── Repositories/        # Implementação dos repositórios
├── Services/            # Implementação das regras de negócio
├── appsettings.json     # Configurações do projeto
├── Program.cs           # Configuração da aplicação
└── README.md            # Documentação do projeto
    </pre>
  </div>

  <div id="execucao" class="section">
    <h2>🚀 Execução do Projeto</h2>
    <ol>
      <li>Clone o repositório:
        <pre><code>git clone https://github.com/seu-usuario/museu-multitematico.git</code></pre>
      </li>
      <li>Navegue até a pasta do projeto:
        <pre><code>cd museu-multitematico</code></pre>
      </li>
      <li>Configure o arquivo <code>appsettings.json</code> com a string de conexão correta para o banco de dados na AWS:
        <pre><code>
"ConnectionStrings": {
  "DefaultConnection": "Host=museupim.c1ieu0e08ts4.us-east-2.rds.amazonaws.com;Port=5432;Database=MuseuDB;Username=root;Password=97558604rsg"
}
        </code></pre>
      </li>
      <li>Restaure as dependências:
        <pre><code>dotnet restore</code></pre>
      </li>
      <li>Compile o projeto:
        <pre><code>dotnet build</code></pre>
      </li>
      <li>Execute as migrações para configurar o banco de dados:
        <pre><code>dotnet ef database update</code></pre>
      </li>
      <li>Inicie a API:
        <pre><code>dotnet run</code></pre>
      </li>
      <li>Acesse a API no navegador:
        <pre><code>http://localhost:5000/swagger</code></pre>
      </li>
    </ol>
  </div>

  <div id="documentacao" class="section">
    <h2>📖 Documentação da API</h2>
    <p>O Swagger UI está disponível em:</p>
    <pre><code>http://localhost:5000/swagger</code></pre>
    <p>Use o Swagger para explorar e testar os endpoints da API.</p>
  </div>

  <div id="melhorias" class="section">
    <h2>✨ Possíveis Melhorias Futuras</h2>
    <ul>
      <li>Adicionar autenticação e autorização (OAuth2, JWT).</li>
      <li>Permitir upload de arquivos maiores com validação de tipo.</li>
      <li>Implementar testes unitários e de integração.</li>
      <li>Melhorar a interface de geração de relatórios.</li>
    </ul>
  </div>

  <script>
    document.querySelectorAll('.toggle-btn').forEach(btn => {
      btn.addEventListener('click', () => {
        const content = btn.nextElementSibling;
        content.style.display = content.style.display === 'block' ? 'none' : 'block';
      });
    });
  </script>
</body>
</html>
