# 安装docker-compose
```shell
sudo curl -L "https://github.com/docker/compose/releases/download/1.27.2/docker-compose-Linux-x86_64" -o /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose
sudo ln -s /usr/local/bin/docker-compose /usr/bin/docker-compose

docker-compose --version
```

---

# 构建Exceptionless
```shell
mkdir -p /home/exceptionless
cd /home/exceptionless
```

下载https://github.com/jieke-wang/ExceptionlessSamples/blob/main/docker-compose.yml到/home/exceptionless目录

```shell
docker-compose up -d
```

访问地址: http://<你的服务器IP>:5000/
自行注册一个账号

---

# 使用Exceptionless
安装如下Package:
- Exceptionless
- Exceptionless.AspNetCore
