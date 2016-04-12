using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class ProjectAnalytics : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Analytics.CustomEvent("computerInfos", new Dictionary<string, object> {
			{"device_model", SystemInfo.deviceModel},
			{"device_name", SystemInfo.deviceName},
			{"device_type", SystemInfo.deviceType},
			{"device_unique_identifier", SystemInfo.deviceUniqueIdentifier},
			{"graphics_memory_size", SystemInfo.graphicsMemorySize},
			{"operating_system", SystemInfo.operatingSystem},
			{"processor_count", SystemInfo.processorCount},
			{"processor_frequency", SystemInfo.processorFrequency},
			{"processor_type", SystemInfo.processorType},
			{"system_memory_size", SystemInfo.systemMemorySize}
		});
	}
}
