import argparse
import requests
import os

minecraft_version_url = "http://launchermeta.mojang.com/mc/game/version_manifest.json"
minecraft_server_filename = "minecraft_server.jar"

# 發送 HTTP 請求獲取版本清單
def get_version_manifest():
    response = requests.get(minecraft_version_url)
    data = response.json()
    return data

# 根據版本清單取得下載連結
def get_download_link(version_manifest, version):
    for v in version_manifest['versions']:
        if v['id'] == version:
            url = v['url']
            response = requests.get(url)
            data = response.json()
            if 'downloads' in data and 'server' in data['downloads']:
                return data['downloads']['server']['url']
            else:
                return None
    return None

# 下載 Minecraft 伺服器 JAR 檔案
def download_minecraft_server(download_link):
    response = requests.get(download_link)
    with open(minecraft_server_filename, 'wb') as file:
        file.write(response.content)
    print(f"{minecraft_server_filename} 下載完成")

# 主程式流程
def main():
    # 解析命令行引數
    parser = argparse.ArgumentParser(description="Get Minecraft server download link.")
    parser.add_argument("--version", help="Minecraft version")
    parser.add_argument("-d", "--download", action="store_true", help="Download the server JAR file")

    args = parser.parse_args()
    target_version = args.version
    download_requested = args.download

    # 如果未提供版本引數，自動選擇最新的穩定版本
    if not target_version:
        version_manifest = get_version_manifest()
        for v in version_manifest['versions']:
            if v['type'] == 'release':
                target_version = v['id']
                break

    # 取得版本清單
    version_manifest = get_version_manifest()

    # 取得下載連結
    download_link = get_download_link(version_manifest, target_version)

    # 輸出下載連結或版本不存在的訊息
    if download_link:
        print(f"The download link for Minecraft {target_version} server is:")
        print(download_link)
        
        # 如果使用者指定了 -d，則執行下載
        if download_requested:
            download_minecraft_server(download_link)
            print(f"{minecraft_server_filename} 下載完成")
    else:
        print(f"Error: Minecraft {target_version} server version does not exist.")

if __name__ == "__main__":
    main()
