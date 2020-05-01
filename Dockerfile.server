FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN apt update && apt upgrade -y

RUN useradd \
  --home-dir /home/dotnet \
  --create-home \
  dotnet

USER dotnet
WORKDIR /var/www

CMD ["tail", "-f", "/dev/null"]

