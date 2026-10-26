# Catálogo de Cursos SESI/SENAI 📚

> Aplicação Full Stack desenvolvida para centralizar, gerenciar e oferecer um catálogo detalhado de cursos disponíveis no SESI e no SENAI.

## 🎯 Objetivo do Projeto

Esta plataforma foi criada com o objetivo de facilitar o acesso à informação sobre qualificações profissionais, cursos técnicos e formações continuadas oferecidas pelas instituições SESI e SENAI. O sistema é composto por uma API desenvolvida no ecossistema .NET e uma interface web moderna construída em React.js.

---

## 🛠️ Tecnologias e Stacks

### Backend
- **Linguagem:** C#
- **Framework:** .NET
- **Banco de Dados:** PostgreSQL

### Frontend
- **Biblioteca Principal:** React.js
- **Ambiente de Execução:** Node.js
- **Ferramentas de Suporte:** TypeScript, Vite, Yarn, ESLint, Prettier, Husky

---

## 🚀 Como Executar o Projeto

Este projeto está dividido em dois repositórios independentes: Backend e Frontend. Siga as instruções abaixo para configurar cada parte em seu ambiente local.

### 🖥️ 1. Configuração do Backend (.NET + Postgres)

**Repositório:** `https://github.com`

#### Pré-requisitos:
- SDK do .NET instalado
- PostgreSQL instalado e em execução
- Visual Studio (ou VS Code com extensões C#)

#### Passo a Passo:
1. Abra o seu gerenciador do PostgreSQL (ex: pgAdmin ou terminal) e **crie um banco de dados** chamado `plataforma_cursos`.
2. Clone o repositório do backend:
   ```bash
   git clone https://github.com
   ```
3. Acesse a pasta do projeto e abra o arquivo de solução **`PlataformaCursos.slnx`** utilizando o Visual Studio.
4. Abra o *Console do Gerenciador de Pacotes* (Package Manager Console) ou a CLI do seu terminal e rode as migrações para criar as tabelas correspondentes:
   ```bash
   Add-Migration Initialm
   Update-Database
   ```
5. Execute/Rode a aplicação através do Visual Studio.

---

### 🌐 2. Configuração do Frontend (React.js)

**Repositório:** `https://github.com`

#### Pré-requisitos:
- Node.js instalado em sua máquina
- VS Code (ou outro editor de código de sua preferência)
- Gerenciador de pacotes Yarn

#### Passo a Passo:
1. Certifique-se de que o **Node.js** está instalado corretamente no seu sistema.
2. Clone o repositório do frontend:
   ```bash
   git clone https://github.com
   ```
3. Abra a pasta do projeto clonado dentro do **VS Code**.
4. Configure o endereço da API do backend alterando a URL base no arquivo:
   - `src/services/api.ts`
5. Abra o terminal integrado do VS Code e instale os módulos/dependências:
   ```bash
   yarn
   ```
6. Inicie o servidor de desenvolvimento local:
   ```bash
   yarn dev
   ```

#### 📦 Produção e Build
Para gerar a versão final otimizada para publicação:
```bash
yarn build
```
Os arquivos estáticos gerados serão salvos na pasta **`dist`**.
