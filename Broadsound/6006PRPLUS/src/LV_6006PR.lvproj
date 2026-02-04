<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="22308000">
	<Property Name="NI.LV.All.SourceOnly" Type="Bool">true</Property>
	<Item Name="My Computer" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="API" Type="Folder" URL="../API">
			<Property Name="NI.DISK" Type="Bool">true</Property>
		</Item>
		<Item Name="VIs" Type="Folder" URL="../VIs">
			<Property Name="NI.DISK" Type="Bool">true</Property>
		</Item>
		<Item Name="BS6006PRPLUS_DLL.lvlib" Type="Library" URL="/&lt;userlib&gt;/BS6006PRPLUS_DLL/BS6006PRPLUS_DLL.lvlib"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="user.lib" Type="Folder">
				<Item Name="BS6006PRPLUS.lvlib" Type="Library" URL="/&lt;userlib&gt;/BS6006PRPLUS_DLL/BS6006PRPLUS.lvlib"/>
				<Item Name="Para Pulse.ctl" Type="VI" URL="/&lt;userlib&gt;/BS6006PRPLUS_DLL/VIs/Para Pulse.ctl"/>
				<Item Name="Para TriggerSource.ctl" Type="VI" URL="/&lt;userlib&gt;/BS6006PRPLUS_DLL/VIs/Para TriggerSource.ctl"/>
				<Item Name="PR Disconnect Device.vi" Type="VI" URL="/&lt;userlib&gt;/BS6006PRPLUS_DLL/VIs/PR Disconnect Device.vi"/>
			</Item>
			<Item Name="vi.lib" Type="Folder">
				<Item Name="Application Directory.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/file.llb/Application Directory.vi"/>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="NI_FileType.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/lvfile.llb/NI_FileType.lvlib"/>
			</Item>
		</Item>
		<Item Name="Build Specifications" Type="Build"/>
	</Item>
</Project>
