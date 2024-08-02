using System.Xml;
 

public class SAPUILandscape
{
	public SAPLononInfo readxml(string path)
	{
		SAPLononInfo sAPLononInfo = new SAPLononInfo();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(path);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Landscape");
		if (xmlNodeList.Count > 0)
		{
			XmlNode xmlNode = xmlNodeList[0];
			XmlNodeList xmlNodeList2 = xmlNode.SelectNodes("Services");
			if (xmlNodeList2.Count > 0)
			{
				XmlNode xmlNode2 = xmlNodeList2[0];
				foreach (XmlNode item in xmlNode2.SelectNodes("Service"))
				{
					if (item.Attributes["type"].Value.ToString() == "SAPGUI")
					{
						SAPLJXX sAPLJXX = new SAPLJXX();
						foreach (XmlAttribute attribute in item.Attributes)
						{
							if (attribute.Name == "uuid")
							{
								sAPLJXX.uuid = attribute.InnerText;
							}
							if (attribute.Name == "name")
							{
								sAPLJXX.name = attribute.InnerText;
							}
							if (attribute.Name == "systemid")
							{
								sAPLJXX.systemid = attribute.InnerText;
							}
							if (attribute.Name == "mode")
							{
								sAPLJXX.mode = attribute.InnerText;
							}
							if (attribute.Name == "server")
							{
								sAPLJXX.server = attribute.InnerText;
							}
							if (attribute.Name == "sncop")
							{
								sAPLJXX.sncop = attribute.InnerText;
							}
							if (attribute.Name == "dcpg")
							{
								sAPLJXX.dcpg = attribute.InnerText;
							}
							if (attribute.Name == "routerid")
							{
								sAPLJXX.routerid = attribute.InnerText;
								XmlNodeList xmlNodeList3 = xmlNode.SelectNodes("Routers");
								if (xmlNodeList3 != null && xmlNodeList3.Count > 0)
								{
									XmlNode xmlNode4 = xmlNodeList3[0];
									XmlNode xmlNode5 = xmlNode4.SelectSingleNode("Router[@uuid = '" + sAPLJXX.routerid + "']");
									foreach (XmlAttribute attribute2 in xmlNode5.Attributes)
									{
										if (attribute2.Name == "name")
										{
											sAPLJXX.routername = attribute2.InnerText;
										}
										if (attribute2.Name == "description")
										{
											sAPLJXX.routerdescription = attribute2.InnerText;
										}
										if (attribute2.Name == "router")
										{
											sAPLJXX.routerrouter = attribute2.InnerText;
										}
									}
								}
							}
							if (!(attribute.Name == "msid"))
							{
								continue;
							}
							sAPLJXX.msid = attribute.InnerText;
							XmlNodeList xmlNodeList4 = xmlNode.SelectNodes("Messageservers");
							if (xmlNodeList4 == null || xmlNodeList4.Count <= 0)
							{
								continue;
							}
							XmlNode xmlNode6 = xmlNodeList4[0];
							XmlNode xmlNode7 = xmlNode6.SelectSingleNode("Messageserver[@uuid = '" + sAPLJXX.msid + "']");
							foreach (XmlAttribute attribute3 in xmlNode7.Attributes)
							{
								if (attribute3.Name == "name")
								{
									sAPLJXX.msname = attribute3.InnerText;
								}
								if (attribute3.Name == "description")
								{
									sAPLJXX.msdescription = attribute3.InnerText;
								}
								if (attribute3.Name == "host")
								{
									sAPLJXX.mshost = attribute3.InnerText;
								}
								if (attribute3.Name == "port")
								{
									sAPLJXX.msport = attribute3.InnerText;
								}
							}
						}
						sAPLononInfo.SAPLJXXes.Add(sAPLJXX);
					}
					if (!(item.Attributes["type"].Value.ToString() == "Reference"))
					{
						continue;
					}
					SAPKJFS sAPKJFS = new SAPKJFS();
					foreach (XmlAttribute attribute4 in item.Attributes)
					{
						if (attribute4.Name == "uuid")
						{
							sAPKJFS.uuid = attribute4.InnerText;
						}
						if (attribute4.Name == "name")
						{
							sAPKJFS.name = attribute4.InnerText;
						}
						if (attribute4.Name == "description")
						{
							sAPKJFS.description = attribute4.InnerText;
						}
						if (attribute4.Name == "systemid")
						{
							sAPKJFS.systemid = attribute4.InnerText;
						}
						if (attribute4.Name == "client")
						{
							sAPKJFS.client = attribute4.InnerText;
						}
						if (attribute4.Name == "user")
						{
							sAPKJFS.user = attribute4.InnerText;
						}
						if (attribute4.Name == "language")
						{
							sAPKJFS.language = attribute4.InnerText;
						}
						if (attribute4.Name == "work_dir")
						{
							sAPKJFS.work_dir = attribute4.InnerText;
						}
						if (attribute4.Name == "link")
						{
							sAPKJFS.link = attribute4.InnerText;
							SAPLJXX sAPLJXX2 = new SAPLJXX();
							XmlNode xmlNode8 = xmlNode2.SelectSingleNode("Service[@uuid = '" + sAPKJFS.link + "']");
							if (xmlNode8 != null)
							{
								foreach (XmlAttribute attribute5 in xmlNode8.Attributes)
								{
									if (attribute5.Name == "uuid")
									{
										sAPLJXX2.uuid = attribute5.InnerText;
									}
									if (attribute5.Name == "name")
									{
										sAPLJXX2.name = attribute5.InnerText;
									}
									if (attribute5.Name == "systemid")
									{
										sAPLJXX2.systemid = attribute5.InnerText;
									}
									if (attribute5.Name == "mode")
									{
										sAPLJXX2.mode = attribute5.InnerText;
									}
									if (attribute5.Name == "server")
									{
										sAPLJXX2.server = attribute5.InnerText;
									}
									if (attribute5.Name == "sncop")
									{
										sAPLJXX2.sncop = attribute5.InnerText;
									}
									if (attribute5.Name == "dcpg")
									{
										sAPLJXX2.dcpg = attribute5.InnerText;
									}
									if (attribute5.Name == "routerid")
									{
										sAPLJXX2.routerid = attribute5.InnerText;
										XmlNodeList xmlNodeList5 = xmlNode.SelectNodes("Routers");
										if (xmlNodeList5 != null && xmlNodeList5.Count > 0)
										{
											XmlNode xmlNode9 = xmlNodeList5[0];
											XmlNode xmlNode10 = xmlNode9.SelectSingleNode("Router[@uuid = '" + sAPLJXX2.routerid + "']");
											foreach (XmlAttribute attribute6 in xmlNode10.Attributes)
											{
												if (attribute6.Name == "name")
												{
													sAPLJXX2.routername = attribute6.InnerText;
												}
												if (attribute6.Name == "description")
												{
													sAPLJXX2.routerdescription = attribute6.InnerText;
												}
												if (attribute6.Name == "router")
												{
													sAPLJXX2.routerrouter = attribute6.InnerText;
												}
											}
										}
									}
									if (!(attribute5.Name == "msid"))
									{
										continue;
									}
									sAPLJXX2.msid = attribute5.InnerText;
									XmlNodeList xmlNodeList6 = xmlNode.SelectNodes("Messageservers");
									if (xmlNodeList6 == null || xmlNodeList6.Count <= 0)
									{
										continue;
									}
									XmlNode xmlNode11 = xmlNodeList6[0];
									XmlNode xmlNode12 = xmlNode11.SelectSingleNode("Messageserver[@uuid = '" + sAPLJXX2.msid + "']");
									foreach (XmlAttribute attribute7 in xmlNode12.Attributes)
									{
										if (attribute5.Name == "name")
										{
											sAPLJXX2.msname = attribute5.InnerText;
										}
										if (attribute5.Name == "description")
										{
											sAPLJXX2.msdescription = attribute5.InnerText;
										}
										if (attribute5.Name == "host")
										{
											sAPLJXX2.mshost = attribute5.InnerText;
										}
										if (attribute5.Name == "port")
										{
											sAPLJXX2.msport = attribute5.InnerText;
										}
									}
								}
								sAPKJFS.ljxx = sAPLJXX2;
							}
						}
						if (attribute4.Name == "shortcut")
						{
							sAPKJFS.shortcut = attribute4.InnerText;
						}
						if (attribute4.Name == "reuse")
						{
							sAPKJFS.reuse = attribute4.InnerText;
						}
					}
					sAPLononInfo.SAPKJFSes.Add(sAPKJFS);
				}
			}
		}
		return sAPLononInfo;
	}
}
