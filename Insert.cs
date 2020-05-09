public int InsertHero(Hero hero)
{
    try
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("InsertHero", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", hero.Name);
                command.Parameters.AddWithValue("@Universe", hero.Universe);

                int id = Convert.ToInt32(command.ExecuteScalar());
                return id;
            }
        }
    }
    catch (Exception ex)
    {
        throw ex;
    }
}
