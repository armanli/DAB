# Diretrizes de Contribuição

Este projeto opera sob uma **Licença Proprietária Restrita**. O modelo de contribuição difere significativamente de projetos Open Source tradicionais. Leia atentamente as diretrizes abaixo antes de interagir com o repositório.

## 1. Política de Licenciamento e Direitos Autorais
Conforme estabelecido em nosso arquivo `LICENSE`, a modificação, engenharia reversa e distribuição deste software são estritamente proibidas sem autorização formal prévia. 

**Termo de Cessão:** Ao submeter qualquer código, correção, documentação ou melhoria através de Pull Requests, **você concorda expressamente em ceder e transferir de forma irrevogável e integral todos os direitos autorais e de propriedade intelectual** da sua contribuição para o autor original.

## 2. Como Contribuir (Sem Código)
A maneira mais eficiente de contribuir sem requerer aprovações legais complexas é via rastreamento de problemas:

* **Reporte de Bugs:** Abra uma *Issue* detalhando o comportamento inesperado, passos exatos para reprodução, ambiente de execução e logs aplicáveis.
* **Propostas de Melhoria:** Abra uma *Issue* descrevendo a funcionalidade desejada, justificando o impacto prático e o Retorno sobre Investimento (ROI) ou benefício direto para os usuários.

## 3. Fluxo Técnico para Contribuição de Código
Caso você seja um desenvolvedor autorizado ou membro da equipe, siga rigorosamente o fluxo abaixo:

### 3.1. Alinhamento Prévio
1. **Nenhum código deve ser escrito sem uma Issue correspondente.** 
2. Aguarde a validação e aprovação técnica de um administrador na Issue antes de iniciar o desenvolvimento.

### 3.2. Padrões de Repositório
* **Nomenclatura de Branches:** Crie branches a partir da `development` adotando o formato `tipo(modulo)/nome da branch` (Ex: `feat/12-dashboard-indicadores` ou `fix/34-erro-autenticacao`).
* **Padrão de Commits:** Utilize *Conventional Commits* para manter o histórico rastreável e automatizável (Ex: `feat(module): adds export of reports in PDF format.`, `fix(module): fixes memory leak in Docker container.`).
* **Qualidade:** O código deve ser direto, otimizado e focado na resolução do problema. Evite abstrações excessivas que não agreguem valor imediato.

### 3.3. Submissão (Pull Request)
1. Abra o PR apontando para a branch `development`.
2. Documente no corpo do PR a Issue resolvida (Ex: `Closes #12`).
3. O PR passará por Code Review focado em arquitetura, segurança e performance. Ajustes podem ser solicitados antes do merge.