<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
	<xsl:template match="/">
		<html>
			<head>
				<title>Employee Details</title>
			</head>
			<body>
				<table border="3px">
					<tr>
						<th>Name</th>
						<th>Phone</th>
						<th>Address</th>
						<th>Mail</th>
					</tr>
					<xsl:for-each select="contacts/employee">
						<tr>
							<td>
								<xsl:value-of select="name"/>
							</td>
							<td>
								<table border="1px">
									<tr>
										<th>Home</th>
										<th>Mobile</th>
									</tr>
									<xsl:for-each select="phones">
										<tr>
										
											<td>
												<xsl:value-of select="phone[@Type='home']"/>
											</td>
											<td>
												<xsl:value-of select="phone[@Type='mobile']"/>
											</td>
										</tr>
									</xsl:for-each>
								</table>
							</td>
							<td>
								<table border="1px">
									<tr>
										<th>Street</th>
										<th>building_no</th>
										<th>region</th>
										<th>city</th>
										<th>country</th>
									</tr>
									<xsl:for-each select="addresses/address">
										<tr>
											<td>
												<xsl:value-of select="street"/>
											</td>
											<td>
												<xsl:value-of select="buldingNumber"/>
											</td>
											<td>
												<xsl:value-of select="region"/>
											</td>
											<td>
												<xsl:value-of select="city"/>
											</td>
											<td>
												<xsl:value-of select="country"/>
											</td>
										</tr>
									</xsl:for-each>
								</table>
							</td>
							<td>
								<xsl:value-of select="mail"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
