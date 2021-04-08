using System;
using System.Collections.Generic;
using System.Text;
using     System.Text.Json.Serialization ;

namespace docker_remote_gui_2.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    public class Port
    {
        [JsonPropertyName("IP")]
        public string IP { get; set; }

        [JsonPropertyName("PrivatePort")]
        public int PrivatePort { get; set; }

        [JsonPropertyName("PublicPort")]
        public int PublicPort { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{IP}:{PublicPort}->{PrivatePort}/{Type}";
        }
    }

    public class Labels
    {
        [JsonPropertyName("com.docker.compose.config-hash")]
        public string ComDockerComposeConfigHash { get; set; }

        [JsonPropertyName("com.docker.compose.container-number")]
        public string ComDockerComposeContainerNumber { get; set; }

        [JsonPropertyName("com.docker.compose.oneoff")]
        public string ComDockerComposeOneoff { get; set; }

        [JsonPropertyName("com.docker.compose.project")]
        public string ComDockerComposeProject { get; set; }

        [JsonPropertyName("com.docker.compose.project.config_files")]
        public string ComDockerComposeProjectConfigFiles { get; set; }

        [JsonPropertyName("com.docker.compose.project.working_dir")]
        public string ComDockerComposeProjectWorkingDir { get; set; }

        [JsonPropertyName("com.docker.compose.service")]
        public string ComDockerComposeService { get; set; }

        [JsonPropertyName("com.docker.compose.version")]
        public string ComDockerComposeVersion { get; set; }

        [JsonPropertyName("maintainer")]
        public string Maintainer { get; set; }
    }

    public class RegistryRegistryUiNet
    {
        [JsonPropertyName("NetworkID")]
        public string NetworkID { get; set; }

        [JsonPropertyName("EndpointID")]
        public string EndpointID { get; set; }

        [JsonPropertyName("Gateway")]
        public string Gateway { get; set; }

        [JsonPropertyName("IPAddress")]
        public string IPAddress { get; set; }

        [JsonPropertyName("IPPrefixLen")]
        public int IPPrefixLen { get; set; }

        [JsonPropertyName("IPv6Gateway")]
        public string IPv6Gateway { get; set; }

        [JsonPropertyName("GlobalIPv6Address")]
        public string GlobalIPv6Address { get; set; }

        [JsonPropertyName("MacAddress")]
        public string MacAddress { get; set; }
    }

    public class Networks
    {
        [JsonPropertyName("registry_registry-ui-net")]
        public RegistryRegistryUiNet RegistryRegistryUiNet { get; set; }
    }

    public class NetworkSettings
    {
        [JsonPropertyName("Networks")]
        public Networks Networks { get; set; }
    }

    public class ContainerListResponse
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Names")]
        public List<string> Names { get; set; }

        [JsonPropertyName("Image")]
        public string Image { get; set; }

        [JsonPropertyName("ImageID")]
        public string ImageID { get; set; }

        [JsonPropertyName("Command")]
        public string Command { get; set; }

        [JsonPropertyName("Created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("Ports")]
        public List<Port> Ports { get; set; }

        [JsonPropertyName("Labels")]
        public Labels Labels { get; set; }

        [JsonPropertyName("State")]
        public string State { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonPropertyName("NetworkSettings")]
        public NetworkSettings NetworkSettings { get; set; }

        [JsonPropertyName("Mounts")]
        public List<object> Mounts { get; set; }
    }
}
