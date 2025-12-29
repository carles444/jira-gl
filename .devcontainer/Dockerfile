FROM mcr.microsoft.com/devcontainers/dotnet:9.0
ARG NODE_VERSION=22
RUN curl -fsSL https://deb.nodesource.com/setup_${NODE_VERSION}.x | bash - \
    && apt-get install -y nodejs
USER vscode
RUN dotnet tool install --global dotnet-ef --version 9.0.0
ENV PATH="$PATH:/home/vscode/.dotnet/tools"